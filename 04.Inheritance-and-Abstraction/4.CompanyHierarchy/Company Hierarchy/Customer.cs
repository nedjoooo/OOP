using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Customer : Person
    {
        private decimal netPurshaceAmount;
        public decimal NetPurshaceAmount
        {
            get { return this.netPurshaceAmount; }
            set
            {
                Validation.NetPurshaceAmount(value);
                this.netPurshaceAmount = value;
            }
        }
        public Customer(int id, string firstName, string lastName, decimal netPurshaceAmount)
            : base (id, firstName, lastName)
        {
            this.NetPurshaceAmount = netPurshaceAmount;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("Net purshace amount: {0}", this.NetPurshaceAmount);
        }
    }
}
