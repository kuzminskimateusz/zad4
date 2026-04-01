namespace LegacyRenewalApp;

public class DiscountStrategyFactory
{
    public IDiscountStrategy GetStrategy(Customer customer, SubscriptionPlan plan)
    {
        return customer.Segment switch
        {
            "Silver" => new SilverDiscount(),
            "Gold" => new GoldDiscount(),
            "Platinum" => new PlatinumDiscount(),
            "Education" when plan.IsEducationEligible => new EducationDiscount(),
            _ => new NoDiscount()
        };
    }
}