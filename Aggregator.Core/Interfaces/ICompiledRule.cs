using Aggregator.Core.Facade;
using Aggregator.Core.Monitoring;

namespace Aggregator.Core.Interfaces
{
    public interface ICompiledRule
    {
        object Execute(IWorkItemExposed self, IWorkItemRepositoryExposed store, IRuleLogger scriptLogger, IScriptLibrary library);
    }
}