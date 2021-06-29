using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2010;
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I am driving my vehicle it is a: {Make},{Model}");
        }
    }
}
