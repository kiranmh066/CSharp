using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment1
{
    public class Customer
    {
        public string Name { get; set; }

        public double Balance { get; set; }

        public string Bank { get; set; }

        public Customer(string name, double balance, string bank)
        {
            this.Name = name;
            this.Balance = balance;
            this.Bank = bank;
        }
    }
}
