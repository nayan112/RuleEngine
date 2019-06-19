namespace RuleEngine
{
    public class Rule : BaseRule
    {

        public Rule(Action actionToBeExecuted): base(actionToBeExecuted)
        {
            
        }

        public override IRuleResult Eval()
        {
            if (!string.IsNullOrEmpty(this.purchaseTestInput.CreditCardNumber) &&
                !this.purchaseTestInput.IsWiretransfer &&
                !this.purchaseTestInput.IsPromotionalPurchase &&
                this.purchaseTestInput.TotalPrice > this.totalPriceLowerBoundary)
            {
                this.ruleResult.IsSuccess = true;
                return this.ruleResult;
            }
            return new RuleResult();
        }
    }
}