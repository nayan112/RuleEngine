using System.Collections.Generic;

namespace RuleEngine
{
    public class RulesChain
    {
        public IRule Rule { get; set; }

        public List<RulesChain> ElseRules { get; set; }

        public bool IsLastInChain { get; set; }

        public RulesChain(IRule mainRule, bool isLastInChain = false)
        {
            this.IsLastInChain = isLastInChain;
            this.ElseRules = new List<RulesChain>();
            this.Rule = mainRule;
        }
    }
}