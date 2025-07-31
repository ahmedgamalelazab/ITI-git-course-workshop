using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount(1, "Ahmed", 8000);
            Console.WriteLine($"ID: {account.GetData()}");
            account.Deposit(1000);
            Console.WriteLine($"ID: {account.GetData()}");
            account.Withdraw(3000);
            Console.WriteLine($"ID: {account.GetData()}");



        }
    }
    public class BankAccount
    {
        private int id;
        private string name;
        private int balance;

        public BankAccount(int _id, string _name)
        {
            id = _id;
            name = _name;
            balance = 6000;
        }

        public BankAccount(int _id, string _name, int _balance)
        {
            id = _id;
            name = _name;

            if (_balance >= 6000) balance = _balance;
            
            else Console.WriteLine("Balance must be 6000 Or More ");
            
        }

        public int GetId()
        {
            return id;
        }
        public void SetData(int _id, string _name)
        {
            if (_id > 0)
                id = _id;
            else
                Console.WriteLine("Id must be More than 0");
            name = _name;

        }
        public string GetData()
        {
            return $"ID: {id}, Name: {name}, Balance : {balance}";
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid amount.");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid amount.");
        }
    }

    
}
