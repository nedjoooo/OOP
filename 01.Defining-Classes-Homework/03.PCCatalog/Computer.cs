using System;
using System.Text;


class Computer
{
    private string name;
    private Component motherboard;
    private Component processor;
    private Component memory;
    private Component hdd;
    private Component graphicsCard;

    public Computer(string name, Component motherboard, Component processor, Component memory, 
        Component hdd, Component graphicsCard)
    {
        this.Name = name;
        this.Motherboard = motherboard;
        this.Processor = processor;
        this.Memory = memory;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
    }

    public string Name 
    {
        get { return this.name; }
        set
        {
            string computerName = value.Trim();
            if(string.IsNullOrEmpty(computerName))
            {
                throw new ArgumentNullException("Computer name cannot be empty!");
            }
            this.name = value;
        }
    }

    public Component Motherboard { get; set; }

    public Component Processor { get; set; }

    public Component Memory { get; set; }

    public Component Hdd { get; set; }

    public Component GraphicsCard { get; set; }

    public void PrintComputer()
    {
        StringBuilder computer = new StringBuilder();
        computer.AppendLine("Computer name: " + this.name);
        string line = "Motherboard: " + this.Motherboard.Name + this.Motherboard.ToString();
        computer.AppendLine(line);
        line = "Processor: " + this.Processor.Name + this.Processor.ToString();
        computer.AppendLine(line);
        line = "Memory: " + this.Memory.Name + this.Memory.ToString();
        computer.AppendLine(line);
        line = "HDD: " + this.Hdd.Name + this.Hdd.ToString();
        computer.AppendLine(line);
        line = "Graphics Card: " + this.GraphicsCard.Name + this.GraphicsCard.ToString();
        computer.AppendLine(line);
        decimal totalPrice = totalComponentPrice;
        computer.AppendLine("Total Price is: " + totalPrice + " BGN");
        Console.WriteLine(computer);
    }

    public decimal totalComponentPrice
    {
        get
        {
            return this.Motherboard.Price + this.Processor.Price + this.Memory.Price + this.Hdd.Price + this.GraphicsCard.Price;
        }
        
    }
}

