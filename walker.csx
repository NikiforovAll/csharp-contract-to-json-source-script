using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class NodeExtensions
{
    public static Node ToNode(PropertyDeclarationSyntax pds)
    {
        var name = pds.Identifier.ToString();
        var type = pds.Type;
        return type switch
        {
            IdentifierNameSyntax ins => CreateNode(name, ins.Identifier.ToString()),
            // TODO: it does not match fully named built-in types
            PredefinedTypeSyntax pts => CreateNode(
                name,
                type: pts.Keyword.ToString(),
                isTerminal: true),
            ArrayTypeSyntax ats => ats.ElementType switch
            {
                PredefinedTypeSyntax pts => CreateNode(
                    name,
                    type: pts.Keyword.ToString(),
                    isTerminal: true),
                IdentifierNameSyntax ins => CreateNode(name, ins.Identifier.ToString()),
                _ => throw new InvalidOperationException(nameof(ToNode))
            },
            _ => throw new InvalidOperationException(nameof(ToNode))
        };
    }

    public static Node CreateNode(
        string name,
        string type,
        bool isTerminal = false)
        => !isTerminal ? new Node()
        {
            Name = name,
            Type = type,
            Nodes = new List<Node>()
        }
        : new TerminalNode()
        {
            Name = name,
            Type = type,
            Nodes = new List<Node>()
        };
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
