using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name can not be empty!");
                }
                this.productName = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if(value.Equals(null))
                {
                    throw new ArgumentNullException("Price can not be empty!");
                }
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price can not be zero or negative!");
                }
                this.price = value;
            }
        }
    }
}
