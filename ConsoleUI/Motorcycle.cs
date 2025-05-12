using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; } = false;
    public Motorcycle () {}
    public Motorcycle (string eYear, string eMake, string eModel) {
        year = eYear;
        make = eMake;
        model = eModel;
    }

    public override void DriveAbstract() {
        Console.WriteLine("Cruising on two wheels");
    }

    public override void DriveVirtual() {
        Console.WriteLine("Vroom... revving up!");
    }
}