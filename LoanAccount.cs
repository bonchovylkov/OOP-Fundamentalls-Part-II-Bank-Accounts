
public class LoanAccount : Accounts,IDepositable
{
    private int loanPeriod;
    public LoanAccount(Customers someCustomer, decimal balance, decimal interestRate, int loanPeriod)
        : base(someCustomer, balance, interestRate)
    {
        this.loanPeriod = loanPeriod;
    }
    public override void Deposit(decimal money)
    {
         this.Balance += money;
    }
    public override decimal CalculateInterest()
    {
        if (this.loanPeriod<=3 && SomeCustomer is Individuals)
        {
            return 0;
        }
        else if (this.loanPeriod<=2 && SomeCustomer is Companies)
        {
            return 0;
        }
        else
        {
            return this.loanPeriod * this.InterestRate;
        }
        
    }
}
