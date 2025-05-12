using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Car : Vehicle
{
    public Car () {}
    public Car (string eYear, string eMake, string eModel) {
        year = eYear;
        make = eMake;
        model = eModel;
    }
    public bool HasTrunk { get; set; } = true;

    public override void DriveAbstract() {
        Console.WriteLine("Driving a car");
    }
}