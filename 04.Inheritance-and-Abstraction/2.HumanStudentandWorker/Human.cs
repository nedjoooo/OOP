using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentandWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                Validation.Name(value, "First Name");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                Validation.Name(value, "Last Name");
                this.lastName = value;
            }
        }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1};", this.FirstName, this.LastName);
        }
    }
}
