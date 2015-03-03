using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentandWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private byte workHoursPerDay;
        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                Validation.Salary(value);
                this.weekSalary = value;
            }
        }

        public byte WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            set
            {
                Validation.WorkHoursPerDay(value);
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("Week Salary: {0:0.00}, Work Hours Per Day: {1}, Money Per Hour: {2:0.00}",
                this.WeekSalary, this.WorkHoursPerDay, MoneyPerHour());
        }
    }
}
