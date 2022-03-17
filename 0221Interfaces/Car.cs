using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal abstract class Car : IVehicle
    {
        public string Name { get; set; }
        public int Fuel { get; set; }
        public int Tank { get; set; }

        public string Model;

        public Car(string name, int fuel, int tank, string model)
        {
            Name = name;
            Fuel = fuel;
            Tank = tank;
            Model = model;
        }

        public bool Drive()
        {
            bool canDrive = true;
            if (Fuel > 0)
            {
                canDrive = true;
            }
            else
            {
                canDrive = false;
            }
            return canDrive;

        }
        public void Refuel(double fuelToRefill)
        {
            var tankAfterRefuel = fuelToRefill + Fuel;
            if (fuelToRefill > Tank - Fuel)
            {
                Console.WriteLine($"Careful, check your input, you will over fill tank by {tankAfterRefuel-Tank} liters");
            }
            else
            {
                Console.WriteLine($"You have refueled, theres {tankAfterRefuel} in your tank");
            }
            
        }
    }
}
