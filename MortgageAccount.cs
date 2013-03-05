public class MortgageAccount : Accounts,IDepositable
{
    private int mortgagePeriod;
    public MortgageAccount(Customers someCustomer, decimal balance, decimal interestRate, int mortgagePeriod)
        : base(someCustomer, balance, interestRate)
    {
        this.mortgagePeriod = mortgagePeriod;
    }
    public override void Deposit(decimal money)
    {
        this.Balance += money;
    }
    public override decimal CalculateInterest()
    {
        if (this.mortgagePeriod<=12 && this.SomeCustomer is Companies)
        {
            return this.InterestRate / 2 * this.mortgagePeriod;
        }
        else if (this.mortgagePeriod<=6 && this.SomeCustomer is Individuals)
        {
            return 0;
        }
        else
        {
            return this.InterestRate * this.mortgagePeriod;
        }
        

    }
}

