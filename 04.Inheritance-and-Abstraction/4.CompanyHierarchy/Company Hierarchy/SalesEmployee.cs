using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales = new List<Sale>();
        public List<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                Validation.Sale(value);
                this.sales = value;
            }
        }
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales)
            : base (id, firstName, lastName,salary, department)
        {
            this.Sales = sales;
        }
        public override string ToString()
        {
            StringBuilder products = new StringBuilder();
            foreach(var sale in sales)
            {
                products.AppendLine(sale.ToString());
            }
            return products.ToString();
        }
    }
}
