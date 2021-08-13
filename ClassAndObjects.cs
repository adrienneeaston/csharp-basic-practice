// Bank account

// Program.cs
using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Adrienne", 20000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} has {account.Balance}.");
        }
    }
}

// BankAccount.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
