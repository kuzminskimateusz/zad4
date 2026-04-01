namespace LegacyRenewalApp;

public interface IDiscountStrategy
{
    decimal CalculateDiscount(decimal amount);
    string notes { get; }
}
public class SilverDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * (decimal)0.05;
    }

    string IDiscountStrategy.notes => "Silver Discount";
}

public class GoldDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * (decimal)0.10;
    }
    string IDiscountStrategy.notes => "Gold Discount";
}

public class PlatinumDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * (decimal)0.15;
    }
    string IDiscountStrategy.notes => "Platinum Discount";
}

public class EducationDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * (decimal)0.20;
    }
    string IDiscountStrategy.notes => "Education Discount";
}

public class NoDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal amount)
    {
        return amount;
    }
    string IDiscountStrategy.notes => "No Discount";
}