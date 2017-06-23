using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aggregator.Core.Interfaces;
using Aggregator.Core.Monitoring;

namespace SampleRule
{
    public class HelloWorldCompiled : ICompiledRule
    {
        public object Execute(IWorkItemExposed self, IWorkItemRepositoryExposed store, IRuleLogger logger, IScriptLibrary library)
        {
            logger.Log("Hello, World from {1} #{0}!", self.Id, self.TypeName);

            return null;
        }
    }
}
