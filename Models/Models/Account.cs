using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Account
    {
        private int id;
        private decimal balance;
        private DateTime dateCreated;
        private double annualInterestRate;
    
        public Account()
        {
            this.Id = 0;
            this.Balance = 0m;
            this.DateCreated = DateTime.Now;
            this.AnnualInterestRate = 0;
        }

        public Account(int id, decimal balance, double annualInterestRate)
        {
            this.Id = id;
            this.Balance = balance;
            this.AnnualInterestRate = annualInterestRate;
            this.DateCreated = DateTime.Now;
        }
    
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0m)
                {
                    balance = value;
                }
            }
        }

        public double AnnualInterestRate
        {
            get
            {
                return annualInterestRate;
            }
            set
            {
                if (value > 0)
                {
                    annualInterestRate = value;
                }
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                if (value != null)
                {
                    dateCreated = value;
                }
            }
        }

        // method returns the id of the current account
        public int GetId()
        {
            return this.Id;
        }

        // method returns the balance of the current account
        public decimal GetBalance()
        {
            return this.Balance;
        }

        // method returns the annual interest of the current account
        public double GetAnnualInterestRate()
        {
            return this.AnnualInterestRate;
        }

        public DateTime GetDateCreated()
        {
            return this.DateCreated;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public void SetBalance(decimal balance)
        {
            this.Balance = balance;
        }

        public void SetAnnualInterestRate(double annualInterestRate)
        {
            this.AnnualInterestRate = annualInterestRate;
        }

        public double GetMonthlyInterest()
        {
            throw new System.NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("The balance of the account is lower than the requested amount.");
                return;
            }
            else
            {
                if (amount < 0m)
                {
                    Console.WriteLine("Invalid amount requested.");
                    return;
                }
                this.Balance -= amount;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0m)
            {
                Console.WriteLine("The deposit should be positive number.");
            }
            else
            {
                this.Balance += amount;
            }
        }
    }
}
