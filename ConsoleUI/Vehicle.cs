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
        public string year { get; set; } = "Unknown";
        public string make { get; set; } = "Generic";
        public string model { get; set; } = "Car";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vroom");
        }


}
}
