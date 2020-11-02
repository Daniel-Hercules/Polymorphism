using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class TechDepartmentEmployee : HiscoxEmployee
    { 
      // "Override" allows the method in the child class to override the 
      //  body of the inherited version of the method with its own body.
        public override void workGreeting()
        {
            Console.WriteLine("Hello! Im Part of the Tech Team on the top floor at Hiscox Uk (London Branch) ");
        }
        public override int floorNumber()
        {
            return 8;
        }
    }
}
