#load "walker.csx"

using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class JTokenWrapper
{
    public JToken Token { get; set; }
    public string Path { get; set; }
    public void Deconstruct(out JToken token, out string path) =>
        (token, path) = (Token, Path);
}

/// <summary>
/// Transforms composite(s) from registry to list contract (list of properties).
/// </summary>
/// <param name="registryQuery"></param>
/// <returns></returns>
public Dictionary<string, List<List<string>>> FlattenAndReducePath(
    IEnumerable<KeyValuePair<string, IList<Node>>> registryQuery)
{
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
            // ! <DEBUG>
            var payload = JsonConvert.SerializeObject(flattened.Select(jw => jw.Path), Formatting.Indented);
            var outFile = "pre-result.json";
            File.WriteAllText(Path.Combine(GetScriptFolder(), "out", outFile), payload);
            // ! END <DEBUG>
            bool ReducePath(IList<JTokenWrapper> source)
            {
                // var queryToReduce = source.Where(t => t.path.Count(c => c == '.') > 1);
                var queryToReduce = source.Where(
                    t => OccurrencesOfSpecialNodeSubstring(t.Path) > 1).ToList();
                var parentTokens = source.Where(
                    t => OccurrencesOfSpecialNodeSubstring(t.Path) == 1).ToList();
                if (queryToReduce.Any() && parentTokens.Count > 0)
                {
                    foreach (var parentToken in parentTokens)
                    {
                        var (token, path) = parentToken;
                        var parentTokenKey = path.Split('.').First(s => s.StartsWith("Nodes"));
                        var parentTokenKeyMatch = path.Replace($".{token}", "");
                        var regex = new Regex(Regex.Escape(parentTokenKey));
                        foreach (var item in queryToReduce
                                                .Where(t => t.Path.StartsWith(parentTokenKeyMatch)))
                        {
                            item.Path = regex.Replace(item.Path, token.Value<string>(), 1);
                        }
                        parentToken.Path = regex.Replace(parentToken.Path, string.Empty, 1);
                        // System.Console.WriteLine(parentToken.Path);
                    }
                    // ReducePath(source);
                }
                else if (parentTokens.Any())
                {
                    foreach (var parentToken in parentTokens)
                    {
                        parentToken.Path = Regex.Replace(parentToken.Path, @"Nodes\[\d+\].*", parentToken.Token.ToString());
                    }
                }
                else
                {
                    return true;
                }
                return false;
                static int OccurrencesOfSpecialNodeSubstring(string s) =>
                    Regex.Matches(s, @"Nodes\[\d+\]").Count;
            }
            var reduced = flattened.ToList();
            while (!ReducePath(reduced)) { };
            var properties = reduced.Select(tw => tw.Path).ToList();
            if (properties.Count > 1)
            {
                properties = properties.Skip(1)
                    .Select(p => $"{properties.First()}.{p}")
                    .ToList();
            }
            contract.Add(properties);
        }
        processedContracts[resolvedKVP.Key] = contract;
    }
    return processedContracts;
}
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
