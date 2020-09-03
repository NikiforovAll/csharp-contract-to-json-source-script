#r "nuget: Microsoft.CodeAnalysis, 3.8.0-2.final"
#r "nuget: Newtonsoft.Json, 12.0.3"

using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


public static string GetScriptPath([CallerFilePath] string path = null) => path;
public static string GetScriptFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);


/// <summary>
/// * Script to generate json-data-source-from-csharp-file
/// </summary>

var file = "CobsService.cs";
var file = "CobsService-light.cs";
private readonly string programText = File.ReadAllText(Path.Combine(GetScriptFolder(), file));
SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

