using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
public abstract class Vehicle
    {
        public string Year { get; set; } = "Unknown";
        public string Make { get; set; } = "Generic";
        public string Model { get; set; } = "Car";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vroom");
        }


}
}
