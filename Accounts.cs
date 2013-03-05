
using System;
public class Accounts : IDepositable
{
    private Customers someCustomer;
    private decimal balance;
    private decimal interestRate;
    private int NumberOfMonts { get; set; }
    protected Accounts(Customers someCustomer, decimal balance, decimal interestRate)
    {
        this.someCustomer = someCustomer;
        this.balance = balance;
        this.interestRate = interestRate;
    }
    protected decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }
    public decimal InterestRate //to chech with protected
    {
        get { return this.interestRate; }
    }
    public Customers SomeCustomer
    {
        get { return this.someCustomer; }
        set { this.someCustomer = value; }
    }
    //methods
    public virtual void Deposit(decimal money)
    {
    }
    public virtual void Drow(decimal money)
    {
    }
    public virtual decimal CalculateInterest()
    {
        return NumberOfMonts * this.interestRate;
    }

}

