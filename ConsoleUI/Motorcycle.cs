using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCart { get; set;}
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"I am driving my vehicle it is a: {Make},{Model}");
        }
    }
}
