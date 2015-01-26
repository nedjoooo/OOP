using System;
using System.Text.RegularExpressions;

class Persons
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty!");
            }
            string trimName = value.Trim();
            if(string.IsNullOrEmpty(trimName))
            {
                throw new ArgumentNullException("Name cannot be empty!");
            }
            if(trimName.Length < 3 || trimName.Length > 50)
            {
                throw new ArgumentOutOfRangeException("Name cannot be less from 3 and cannot be greather from 50 letters!");
            }

            this.name = value;

        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid value of age");
            }


            this.age = value;

        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                Regex emailMatcher = new Regex(@"[A-Za-z0-9_\-\+\.=\*]+@[A-Za-z0-9_\-\+\.=\*]+\.[a-z]{2,3}");
                if (emailMatcher.IsMatch(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Not valid email");
                }
            }
            else
            {
                this.email = value;
            }
        }
    }

    public Persons(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    //public Persons(string name, int age)
    //{
    //    this.Name = name;
    //    this.Age = age;
    //}

    public override string ToString()
    {
        return "This person a called " + this.name + ". He / She is " + this.age + " years old. His/Her email adress is " + (string.IsNullOrEmpty(this.email) ? "none" : this.email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persons ivan = new Persons("Ivan", 32, "p@carvulka.bg");
        Persons dragan = new Persons("Dragan", 33);

        Console.WriteLine(ivan);
        Console.WriteLine(dragan);
    }
}

