using System.Collections.Generic;
using System.Globalization;
namespace increaseSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            List<Employees> employees = new List<Employees>();
            Console.Write("How many employees will be registered: ");
            int quantEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantEmployees; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employees.Add(new Employees(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int code = int.Parse(Console.ReadLine());
            Employees idExist = employees.Find(x => x.Id == code);
            if (idExist!= null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idExist.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("this id doesn't exist!");
            }
            Console.WriteLine("Updated list of employees");
            foreach (Employees obj in employees)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
