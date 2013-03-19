using System;

namespace _2_Humans.Model
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Hours cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal daySalary = WeekSalary / 7;
            decimal hourSalary = daySalary / (decimal)workHoursPerDay;

            return hourSalary;
        }

        public Worker(string firstName, string lastName, decimal weekSalary,
            double workHoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
    }
}
