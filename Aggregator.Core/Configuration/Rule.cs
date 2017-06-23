using Aggregator.Core.Interfaces;

namespace Aggregator.Core.Configuration
{
    /// <summary>
    /// Represents a Rule of <see cref="TFSAggregatorSettings"/>.
    /// </summary>
    public class Rule
    {
        public string Name { get; set; }

        public RuleScope[] Scope { get; set; }

        public ScriptElement Script { get; set; }

        public System.Type CompiledRuleType { get; set; }
        public ICompiledRule CompiledRule { get; set; }

    }
}
