using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;
        public string Name 
        {
            get { return this.name; }
            private set
            {
                Validation.Name(value);
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                Validation.Age(value);
                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }
        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return String.Format("Name: {0}; Age: {1}; Gender: {2}; Sound: {3}",
                this.Name, this.Age, this.Gender, this.ProduceSound());
        }
    }
}
