﻿using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public Truck()
		{
		}

        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F150";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; } = true;

        public bool HasFourWheelDrive { get; set; }

    public void Drive()
        {
          if (HasFourWheelDrive)
          {
             Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");
          }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");
            }
        }
        
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

