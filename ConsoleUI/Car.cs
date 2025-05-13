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
        Year = eYear;
        Make = eMake;
        Model = eModel;
    }
    // You told me to have a HasTrunk property and override the DriveAbstract method but didnt I already do that?
    public bool HasTrunk { get; set; } = true;
    public override void DriveAbstract() {
        Console.WriteLine("Driving a car");
    }
}