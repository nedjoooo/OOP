using System;
using System.Text;

class Component
{
    private string name;
    private decimal price;
    private string details;

    public Component(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public string Name 
    {
        get { return this.name; }
        set
        {
            string cmpName = value.Trim();
            if(string.IsNullOrEmpty(cmpName))
            {
                throw new ArgumentNullException(this.name + " cannot be empty");
            }
            this.name = value;
        }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negatice or zero!");
            }
            this.price = value;
        }
    }
    public string Details
    {
        get { return this.details; }
        set { this.details = value; }
    }

    public override string ToString()
    {
        StringBuilder component = new StringBuilder();
        component.Append(" Price: " + this.price + ".");
        if(!string.IsNullOrEmpty(this.details))
        {
            component.Append(" Details: " + this.details);
        }
        return component.ToString();
    }

}

