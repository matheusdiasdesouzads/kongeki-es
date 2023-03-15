namespace VioletScript.Parser.Verifier;

using System.Collections.Generic;
using VioletScript.Parser.Operator;
using VioletScript.Parser.Diagnostic;
using VioletScript.Parser.Semantic.Logic;
using VioletScript.Parser.Semantic.Model;
using VioletScript.Parser.Source;
using Ast = VioletScript.Parser.Ast;

using DiagnosticArguments = Dictionary<string, object>;

public partial class Verifier
{
    public void VerifySimpleVariableDeclaration(Ast.SimpleVariableDeclaration svd)
    {
        var output = m_Frame.Properties;
        foreach (var binding in svd.Bindings)
        {
            VerifyVariableBinding(binding, svd.ReadOnly, output);
        }
    }
}