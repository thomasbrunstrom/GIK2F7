using System;
namespace Föreläsning3 
{
public class Bank {
    private string Name;
    public Bank(string Name)
    {
        this.Name = Name;
    }
    public string GetBankName()
    {
        return Name;
    }
}

public class Employee 
{
    private string Name;
    public Employee(string Name)
    {
        this.Name = Name;
    }
    public string GetEmployeeName()
    {
        return Name;
    }
}
public class Association
{
    public static void main(string[] args)
    {
        Bank bank = new Bank("Axis");
        Employee emp = new Employee("Neha");
        Console.WriteLine("{0} is employee of {1}", emp.GetEmployeeName(), bank.GetBankName());
    }
}
}