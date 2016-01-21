using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Johnny", "MacEnroe", 1000000.00m);
            Employee employee2 = new Employee("Johnny", "Goode", 25.00m);

            int myNumberInt = 5;

            Console.WriteLine(myNumberInt);
            changeAnInt(myNumberInt);
            Console.WriteLine(myNumberInt);

            Console.WriteLine(employee1.ToString());
            changeAnObject(employee1);
            Console.WriteLine(employee1.ToString());


            Console.WriteLine(employee1.GetFullName());
            Console.WriteLine(employee2.ToString()); 
          
            //Showing how to use an array with objects
            Employee[] employees = new Employee[10];

            employees[0] = new Employee("Daryl", "Hammond", 255.55m);
            employees[1] = new Employee("Austin", "Powers", 100.33m);
            employees[2] = new Employee("Dustin", "Hoffman", 450.23m);
            employees[3] = new Employee("Crazy", "Eyes", 0.01m);
            employees[4] = new Employee("Billy", "Madison", 0.50m);          
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        static void changeAnInt(int myNumberInt)
        {
            myNumberInt = 450;
        }

        static void changeAnObject(Employee employee)
        {
            employee.FirstNameString = "Thor";
        }
    }
}