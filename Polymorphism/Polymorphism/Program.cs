using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            HiscoxEmployee newEmployee = new HiscoxEmployee();
            HiscoxEmployee techEmployee = new TechDepartmentEmployee();
            HiscoxEmployee hrEmployee = new HRDepartmentEmployee();

            newEmployee.workGreeting();
            techEmployee.workGreeting();
            hrEmployee.workGreeting();

        }
    }
}
