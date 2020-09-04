#r "nuget: Microsoft.CodeAnalysis, 3.8.0-2.final"
#r "nuget: Newtonsoft.Json, 12.0.3"
#r "nuget: Colorful.Console, 1.2.11"

#load "walker.csx"
#load "flattener.csx"
#load "dependency-builder.csx"
#load "scripts-utils.csx"

using System.Drawing;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;


/// <summary>
/// * Script to generate json-data-source-from-csharp-file
/// </summary>
/// 
var file = "CobsService.cs";
// var file = "CobsService-light.cs";
private readonly string programText = File.ReadAllText(
    Path.Combine(GetScriptFolder(), "test-data", file));

SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

var collector = new ContractDefinitionCollector();
collector.Visit(root);

WriteProgress($"Parsing source file... [{file}]");
WriteLine("Found:");
var registry = collector.TopLevelDeclarations;
foreach (var item in registry)
{
    WriteLine($"\t{item.Key}");
}

BuildDependencyGraph(registry);

var models = new List<string>()
{
    "CobsDslSubmitOrderRequest"
};
var registryQuery = registry.Where(kvp => models.Contains(kvp.Key));
WriteProgress("Flattening of object graph...");

var processedContracts = FlattenAndReducePath(registryQuery);
WriteProgress("Processing...");
foreach (var item in models)
{
    WriteLine($"\t{item}");
}
var transformed = processedContracts.ToDictionary(
    kvp => kvp.Key,
    kvp => kvp.Value.SelectMany(l => l).Select(p => $"{p}"));
var payload = JsonConvert.SerializeObject(transformed, Formatting.Indented);

var outFile = "result.json";
WriteProgress($"Writing to {outFile}...");
File.WriteAllText(Path.Combine(GetScriptFolder(), "out", outFile), payload);

void WriteProgress(string m)
{
    Colorful.Console.WriteLine(m, Color.Yellow);
}
