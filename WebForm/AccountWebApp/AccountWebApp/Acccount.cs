using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountWebApp
{
    [Serializable]
    public class Acccount
    {
        
        public string AccountNumber { set; get; }
        public string CustomerName { set; get; }

        private double balance;
        public Acccount()
        {
            balance = 0;
        }

        public string deposit(double amount)
        {
            balance += amount;
            return "Deposite successful";
        }

        public string wirthdraw(double amount)
        {
            if (amount > balance)
            {
                return "Insufficient balance";
            }
            else
            {
                balance -= amount;
                return " wirthdraw Successfully";
            }
        }

        public string report()
        {
            return " Account Number " + AccountNumber + " " + " Name" + CustomerName + " Balance" + balance;
        }
    }
}