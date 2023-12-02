using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamilov_T_R_Hometask_21._10._23
{

    class Account
    {
        private string number;
        private double balance;
        private AccountType type;


        public Account(string number, double balance, AccountType type)
        {
            this.number = number;
            this.balance = balance;
            this.type = type;
        }


        public void SetNumber(string number)
        {
            this.number = number;
        }

        public string GetNumber()
        {
            return this.number;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetType(AccountType type)
        {
            this.type = type;
        }

        public AccountType GetType()
        {
            return this.type;
        }


        public override string ToString()
        {
            return $"Номер счета: {this.number}\nБаланс: {this.balance}\nТип счета: {this.type}";
        }


        public void Transfer(Account toAccount, double amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;

                toAccount.balance += amount;
            }
        }
    }
}