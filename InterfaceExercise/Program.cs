using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mustang = new Car();

            var F150 = new Truck();

            var Exsplorer = new Suv();
            var vehicles = new List<IVehicle> { Mustang,F150,Exsplorer };

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }
        }

        
    }
}
