using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;
        public string ProductName
        {
            get { return this.productName; }
            set
            {
                Validation.Name(value);
                this.productName = value;
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                Validation.Date(value, "Product");
                this.date = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                Validation.Price(value);
                this.price = value;
            }
        }
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public override string ToString()
        {
            return String.Format("Product name: {0}; Date: {1}; Price: {2}", this.ProductName, this.Date, this.Price);
        }
    }
}
