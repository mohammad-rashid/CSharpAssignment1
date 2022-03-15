//Please find Employee.cs file for Employee Class.

using System;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID : ");
            
            var id = Console.ReadLine();

            System.Console.WriteLine("Enter Name : ");
            var name = Console.ReadLine();
            System.Console.WriteLine("Enter Department Name : ");
            var depName = Console.ReadLine();
            
            var emp = new Employee(long.Parse(id), name, depName); // Instantiating new object
            emp.MethodCalled+=OnMethodCalled; //Event Called

            Console.WriteLine("\n\n");

            emp.GetId();
            Console.WriteLine("\n");
            emp.GetName();
            Console.WriteLine("\n");
            emp.GetDepartmentName();

            System.Console.WriteLine("\n\n");

            /* For explicitely Changing Data:

            emp.GetId(123);
            emp.GetName("Mohammad Rashid");
            emp.GetDepartmentName("Software Development");

            emp.GetId();
            emp.GetName();
            emp.GetDepartmentName();
            */
        }
        static void OnMethodCalled(object sender)
        {
            Console.WriteLine($"{sender} method called");
        }
    }
}
