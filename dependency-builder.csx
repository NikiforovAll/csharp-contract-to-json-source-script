#load "walker.csx"

/// <summary>
/// Resolved object graph  based on top-level defined entities.
/// </summary>
/// <param name="registry"></param>
public void BuildDependencyGraph(IDictionary<string, IList<Node>> registry)
{
    foreach (var toResolve in registry.Values.SelectMany(n => n))
    {
        BuildDependencyGraph(registry, toResolve, out var _);
    }
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

