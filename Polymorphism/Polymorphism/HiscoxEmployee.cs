using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //Parent Class
    class HiscoxEmployee
    {
        public virtual void workGreeting()
        {
            Console.WriteLine("Hello! I work at Hiscox at the London Branch!");
        }
        public virtual int floorNumber()
        {
            return 0;
        }
    }
}
