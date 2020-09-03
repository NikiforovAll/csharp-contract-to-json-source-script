using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class NodeExtensions
{
    public static Node ToNode(PropertyDeclarationSyntax pds)
    {
        return null;
    }
}

public class Node
{
    public string Name { get; set; }
    public string Type { get; set; }
    public IList<Node> Nodes { get; set; }
}

public class TerminalNode : Node
{
}

class ContractDefinitionCollector : CSharpSyntaxWalker
{
    public IDictionary<string, IList<Node>> TopLevelDeclarations { get; set; } 
        = new Dictionary<string, IList<Node>>();
    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        // base.VisitClassDeclaration(node);
        var properties = node.Members
            .OfType<PropertyDeclarationSyntax>()
            .Select(p => NodeExtensions.ToNode(p))
            .ToList();
        // foreach (var item in node.Members.OfType<PropertyDeclarationSyntax>())
        // {
        //     // WriteLine(item.Identifier);
        //     var n = NodeExtensions.ToNode(item);
        // }
        TopLevelDeclarations.Add(node.Identifier.ToString(), properties);
    }
}
