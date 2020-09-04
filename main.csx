#r "nuget: Microsoft.CodeAnalysis, 3.8.0-2.final"
#r "nuget: Newtonsoft.Json, 12.0.3"
#r "nuget: SharpPad, 1.0.4"
#r "nuget: Microsoft.Extensions.Logging, 3.1.1"
#r "nuget: Microsoft.Extensions.Logging.Console, 3.1.1"
#load "walker.csx"
using System.Xml.Linq;
using System.Text.RegularExpressions;

using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// using SharpPad;

public static string GetScriptPath([CallerFilePath] string path = null) => path;
public static string GetScriptFolder([CallerFilePath] string path = null) => 
    Path.GetDirectoryName(path);

/// <summary>
/// * Script to generate json-data-source-from-csharp-file
/// </summary>

// ! logging from csx doesn't work as expected
// var loggerFactory = LoggerFactory.Create(builder =>
//     {
//         builder.AddConsole();
//     });
// ILogger logger = loggerFactory
//     .CreateLogger("main.csx");
// var file = "CobsService.cs";
var file = "CobsService-light.cs";
private readonly string programText = File.ReadAllText(
    Path.Combine(GetScriptFolder(), "test-data", file));

SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

var collector = new ContractDefinitionCollector();
collector.Visit(root);

WriteLine($"Parsed source file: {file}");
WriteLine("Found:");
var registry = collector.TopLevelDeclarations;
foreach (var item in registry)
{
    WriteLine(item.Key);
}

void BuildDependencyGraph(
    IDictionary<string, IList<Node>> registry,
    Node node,
    out Node mutated)
{
    if (!(node is TerminalNode) && registry.ContainsKey(node.Type))
    {
        IList<Node> typeNodes = registry[node.Type];
        foreach (var tn in typeNodes)
        {
            if (!tn.Nodes.Any())
            {
                BuildDependencyGraph(registry, tn, out var _);
            }
        }
        (node.Nodes as List<Node>).AddRange(typeNodes);
    }
    mutated = node;
}

foreach (var toResolve in registry.Values.SelectMany(n => n))
{
    BuildDependencyGraph(registry, toResolve, out var _);
}
// var payload = collector.TopLevelDeclarations;

var excludePropertiesPatterns = new List<string>()
{
    "Type",
    "Nodes"
};

bool IsExcludedPath(string path) =>
    excludePropertiesPatterns.Any(epp => path.EndsWith(epp));

string TransformPath(JToken token, string objectPath)
{
    var value = token.ToString();
    var s = objectPath.Replace("Name", value);
    // Regex.Replace(objectPath, @"\[\d+\]", string.Empty)
    return s;
}


class JTokenWrapper
{
    public JToken Token { get; set; }
    public string Path { get; set; }
    public void Deconstruct(out JToken token, out string path) =>
        (token, path) = (Token, Path);
}

var registryQuery = registry.Where(kvp => kvp.Key == "CobsDslSubmitOrderRequest");
var processedContracts = new Dictionary<string, List<List<string>>>();
foreach (var resolvedKVP in registryQuery)
{
    // var resolved = registry["CobsDslSubmitOrderRequest"][0];
    var resolvedList = resolvedKVP.Value;
    var contract = new List<List<string>>();
    foreach (var resolved in resolvedKVP.Value)
    {
        var flattened = JObject.FromObject(resolved)
            .SelectTokens("$..*")
            .Where(t => !t.HasValues && !IsExcludedPath(t.Path))
            .Select(t => new JTokenWrapper() { Token = t, Path = TransformPath(t, t.Path) });
        // .Select((JToken t) => (token: t, path: t.Path))
        // .Select((JToken t) => (token: t, path: TransformPath(t, t.Path)))
        // .ToDictionary(t => TransformPath(t, t.Path), t => t.ToString());
        // .ToList<(JToken token, string path)>();
        
        void ReducePath(IList<JTokenWrapper> source)
        {
            // var queryToReduce = source.Where(t => t.path.Count(c => c == '.') > 1);
            var queryToReduce = source.Where(
                t => OccurrencesOfSpecialNodeSubstring(t.Path) > 1).ToList();
            var parentTokens = source.Where(
                t => OccurrencesOfSpecialNodeSubstring(t.Path) == 1).ToList();
            if (queryToReduce.Any())
            {
                foreach (var parentToken in parentTokens)
                {
                    var (token, path) = parentToken;
                    var parentTokenKey = path.Split('.').First(s => s.StartsWith("Nodes"));
                    var regex = new Regex(Regex.Escape(parentTokenKey));
                    foreach (var item in queryToReduce
                                            .Where(t => t.Path.StartsWith(parentTokenKey)))
                    {
                        item.Path = regex.Replace(item.Path, token.Value<string>(), 1);
                    }
                    parentToken.Path = regex.Replace(parentToken.Path, string.Empty, 1);
                }
                ReducePath(source);
            }
            else if (parentTokens.Any())
            {
                foreach (var parentToken in parentTokens)
                {
                    parentToken.Path = Regex.Replace(parentToken.Path, @"Nodes\[\d+\].*", parentToken.Token.ToString());
                }
            }
        
            static int OccurrencesOfSpecialNodeSubstring(string s) =>
                Regex.Matches(s, @"Nodes\[\d+\]").Count;
        }
        var reduced = flattened.ToList();
        ReducePath(reduced);
        var properties = reduced.Select(tw => tw.Path).ToList();
        if(properties.Count > 1)
        {
            properties = properties.Skip(1)
                .Select(p => $"{properties.First()}.{p}")
                .ToList();
        }
        contract.Add(properties);
    }
    processedContracts[resolvedKVP.Key] = contract;
}

var transformed = processedContracts.ToDictionary(
    kvp => kvp.Key,
    kvp => kvp.Value.SelectMany(l => l).Select(p => $"{p}"));
            // .Where(p => !p.StartsWith('.')));
var payload = JsonConvert.SerializeObject(transformed, Formatting.Indented);
File.WriteAllText(
    Path.Combine(GetScriptFolder(), "out", "result.json"), payload);
// await collector.TopLevelDeclarations.Dump();
