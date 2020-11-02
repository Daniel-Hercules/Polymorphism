using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class HRDepartmentEmployee : HiscoxEmployee
    {
        // "Override" allows the method in the child class to override the 
        //  body of the inherited version of the method with its own body.
        public override void workGreeting()
        {
            Console.WriteLine("Hello! Im part of the HR Team at Hiscox UK (Colchester branch)");
        }
        public override int floorNumber()
        {
            return 2;
        }
    }
}
