using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace increaseSalary
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return " ID: " + Id
                + ", Name: " + Name
                + ", Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void IncreaseSalary(double percent)
        {
            Salary += Salary * (percent/100);
        }
    }
}
