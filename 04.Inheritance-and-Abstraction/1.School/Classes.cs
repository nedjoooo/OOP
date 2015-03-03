using System;
using System.Collections.Generic;
using System.Text;

namespace _1.School
{
    public class Classes
    {
        private string className;
        List<Teacher> teachers = new List<Teacher>();
        private string details;

        public string ClassName 
        {
            get { return this.className; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class name can not be empty!");
                }
                this.className = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.Empty == value)
                {
                    throw new ArgumentNullException("Details can not be empty string!");
                }
                this.details = value;
            }
        }

        public Classes(string className, List<Teacher> teachers = null, string details = null)
        {
            this.ClassName = className;
            this.teachers = teachers;
            this.Details = details;
        }
    }
}
