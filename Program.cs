using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.bankClasses
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Customers> customersList = new List<Customers>();
            customersList.Add(new Individuals(20, "Pesho", "M"));
            customersList.Add(new Individuals(100, "Kiro", "M"));
            customersList.Add(new Companies("Krada vsichko OOD",9999));
            customersList.Add(new Companies("Fantom OOD", 1212));
            customersList.Add(new Companies("Kyrti i izvozva", 5432));
            List<Accounts> accountsList = new List<Accounts>();
            accountsList.Add(new DepositAccount(customersList[0], 1010, 0.06m, 10)); // same parameteres to see the diference
            accountsList.Add(new DepositAccount(customersList[1], 2000, 0.1m, 10));
            accountsList.Add(new DepositAccount(customersList[2], 1000, 0.06m, 10));
            accountsList.Add(new LoanAccount(customersList[3], 1000, 0.06m, 10)); //after override
            accountsList.Add(new MortgageAccount(customersList[4], 1000, 0.06m, 10));
            
            foreach (var account in accountsList)
            {
                Console.WriteLine(account.CalculateInterest());
                account.Deposit(2000);
                if (account is DepositAccount)
                {
                    account.Drow(100);
                    Console.WriteLine("I 've just drow out some money");
                }
            }
        }
    }
}
