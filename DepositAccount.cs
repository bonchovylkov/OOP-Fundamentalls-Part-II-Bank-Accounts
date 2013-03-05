
using System;
public  class DepositAccount : Accounts,IDrowable 
    {
      private int depositPeriod;

      public DepositAccount(Customers someCustomer, decimal balance, decimal interestRate,int depositPeriod)
          : base(someCustomer, balance, interestRate)
      {
          this.depositPeriod = depositPeriod;
      }

      public override void Deposit(decimal money)
      {
          this.Balance += money;
      }
      public override void Drow(decimal money)
      {
          if (this.Balance > money)
          {
              this.Balance -= money;
          }
          else
          {
              throw new Exception("You don't have enought money in the account");
          }
      }
      public override decimal CalculateInterest()
      {
          if (this.Balance<=1000)
          {
              return 0;
          }
          else
          {
              return this.depositPeriod * this.InterestRate;
          }
        
      }
    }

