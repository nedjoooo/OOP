using System;

namespace _1.School
{
    public abstract class Person
    {
        private string name;
        private string details;
      
        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (value.Length < 3)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    this.name = value;
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Name is can not be empty!");
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Name is can not be less by three letters!");
                }
            }
        }

        public string Details 
        {
            get { return this.details; }
            set
            {
                if(String.Empty == value)
                {
                    throw new ArgumentNullException("Details can not be empty string!");
                }
                this.details = value;
            }
        }

        public Person(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }
    }
}
