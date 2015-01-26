using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private string price;

    public Laptop(string model, string price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, string price, string manufacturer = null, string processor = null, string ram = null, string graphicsCard = null,
        string hdd = null, string screen = null, string battery = null, string batteryHours = null)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = new Battery(battery, batteryHours);
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Laptop model can not be empty!");
            }
            this.model = value;
        }
    }

    public string Price
    {
        get
        {
            return this.price;
        }
        set
        {
            Regex matcher = new Regex(@"\-*\d+\.*\d*");
            Match match = matcher.Match(value);
            string strPrice;
            float priceValue;
            if(match.Success)
            {
                strPrice = match.Value;
                priceValue = float.Parse(strPrice);
                if (priceValue <= 0)
                {
                    throw new IndexOutOfRangeException("Price can not be negative or zero!");
                }
            }           
            this.price = value;
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Manifacturer can not be empty!");
            }
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Processor can not be empty!");
            }
            this.processor = value;
        }
    }
    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Ram can not be empty!");
            }
            Regex matcher = new Regex(@"\-*\d+");
            Match match = matcher.Match(value);
            string strMemory;
            int memory;
            if (match.Success)
            {
                strMemory = match.Value;
                memory = int.Parse(strMemory);
                if (memory < 1)
                {
                    throw new ArgumentOutOfRangeException("Ram can not be less from 1 GB!");
                }
            }         
            this.ram = value; 
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Graphics card can not be empty!");
            }
            this.graphicsCard = value; 
        }
    }
    public string Hdd
    {
        get { return this.hdd; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("HDD can not be empty!");
            }
            Regex matcher = new Regex(@"\-*\d+");
            Match match = matcher.Match(value);
            string strHardDisk;
            int hardDisk;
            if (match.Success)
            {
                strHardDisk = match.Value;
                hardDisk = int.Parse(strHardDisk);
                if (hardDisk < 100)
                {
                    throw new ArgumentOutOfRangeException("HDD can not be less from 100 GB!");
                }
            }        
            this.hdd = value; 
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen can not be empty!");
            }
            this.screen = value; 
        }
    }

    public Battery Battery { get; set; }

    public override string ToString()
    {
        StringBuilder resultStr = new StringBuilder();
        resultStr.AppendLine("Laptop Model: " + this.model);
        resultStr.AppendLine("Price: " + this.price);
        if(this.manufacturer != null)
        {
            resultStr.AppendLine("Manufacturer: " + this.manufacturer);
        }
        if (this.processor != null)
        {
            resultStr.AppendLine("Processor: " + this.processor);
        }
        if (this.ram != null)
        {
            resultStr.AppendLine("Ram: " + this.ram);
        }
        if (this.graphicsCard != null)
        {
            resultStr.AppendLine("Graphics Card: " + this.graphicsCard);
        }
        if (this.hdd != null)
        {
            resultStr.AppendLine("HDD: " + this.hdd);
        }
        if (this.screen != null)
        {
            resultStr.AppendLine("Screen: " + this.screen);
        }
        if(this.Battery != null)
        {
            resultStr.Append(this.Battery.ToString());
        }
        return resultStr.ToString();
    }
}