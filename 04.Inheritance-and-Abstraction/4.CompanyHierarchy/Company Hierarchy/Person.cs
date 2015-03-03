using System;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public int ID
        {
            get { return this.id; }
            set
            {
                Validation.ID(value);
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                Validation.Name(value);
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                Validation.Name(value);
                this.lastName = value;
            }
        }
        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return String.Format("Name: {0} {1};", this.FirstName, this.LastName);
        }
    }
}
