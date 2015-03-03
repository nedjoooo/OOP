using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public delegate void PropertyChangedEvent(object sender, PropertyChanged eventArgs);
    class Student
    {
        private string name;
        private uint age;
        private PropertyChanged propertyChanged;

        public event PropertyChangedEvent ChangedProperty;

        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }

                if(value != this.name)
                {
                    this.propertyChanged = new PropertyChanged("Name", this.Name, value);
                    this.OnPropertyChanged(this, propertyChanged);
                }

                this.name = value;
            }
        }
        public uint Age
        {
            get { return this.age; }
            set
            {
                if (value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be least by 120!");
                }

                if (value != this.age)
                {
                    this.propertyChanged = new PropertyChanged("Age", this.Name, value);
                    this.OnPropertyChanged(this, propertyChanged);
                }

                this.age = value;
            }
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChanged propertyChanged)
        {
            if(ChangedProperty != null)
            {
                ChangedProperty(this, propertyChanged);
            }           
        }
    }
}
