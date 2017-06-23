using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator.Core.Configuration
{
    public class ScriptElement
    {
        public ScriptElement()
        {
        }

        public ScriptElement(string script)
        {
            Script = script;
        }

        public string Script { get; set; }
    }
}
