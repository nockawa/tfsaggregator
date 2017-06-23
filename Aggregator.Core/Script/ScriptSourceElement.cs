using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator.Core.Script
{
    public enum ScriptSourceElementType
    {
        Rule,
        CompiledRule,
        Snippet,
        Function
    }

    public class ScriptSourceElement
    {
#pragma warning disable SA1401 // FieldsMustBePrivate
        public string Name;
        public ScriptSourceElementType Type;
        public string SourceCode;
        public Type CompiledRuleType;
#pragma warning restore SA1401 // FieldsMustBePrivate
    }
}
