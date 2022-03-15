using System;

namespace EmployeeDetails;
class Employee
{
    public delegate void MethodCalledDelegate(object sender);  //Declaring delegate for event
    public event MethodCalledDelegate MethodCalled; //Declaring event
    private long Id; 
    private string Name;
    private string DepartmentName;

    public Employee(long Id, string Name, string DepartmentName) //constructor
    {
        this.Id = Id;
        this.Name = Name;
        this.DepartmentName = DepartmentName;
    }
    public void GetId()
    {
        if(MethodCalled!=null)
        {
            MethodCalled("GetId()");
        }
        Console.WriteLine($"Your ID : {Id}");
    }
    public void GetName()
    {
        if(MethodCalled!=null)
        {
            MethodCalled("GetName()");
        }
        Console.WriteLine($"Your Name : {Name}");
    }
    public void GetDepartmentName()
    {
        if(MethodCalled!=null)
        {
            MethodCalled("GetDepartmentName()");
        }
        Console.WriteLine($"Your Department Name : {DepartmentName}");
    }
    public void GetId(long Id) //overloaded method
    {
        this.Id = Id;
    }
    public void GetName(string Name)    //overloaded method
    {
        this.Name=Name;
    }
    public void GetDepartmentName(string DepartmentName)    //overloaded method
    {
        this.DepartmentName = DepartmentName;
    }
}