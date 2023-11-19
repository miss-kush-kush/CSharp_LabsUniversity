using CarTester.Interfaces;
using CarTester.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Hybrids
{
    public class PetrolElectricCar: Car, IPetrolCar, IElectricCar
    {
        private bool petrolFuelState = false;
        private bool electricFuelState = false;
        string? CarType => "PetrolElectric";

        public override void Refuel()
        {
            ((IPetrolCar)this).Refuel();
            ((IElectricCar)this).Refuel();
        }

        public override void Run()
        {
            if (EngineState)
            {
                if (petrolFuelState)
                {
                    Console.WriteLine($"The {CarType} car is running on Petrol");
                    petrolFuelState = false;
                    FuelState = false;
                }
                else if (electricFuelState)
                {
                    Console.WriteLine($"The {CarType} car is running on Electricity");
                    electricFuelState = false;
                    FuelState = false;
                }
                else
                {
                    Console.WriteLine("No fuel available for the car.");
                }
            }
            else
            {
                Console.WriteLine("The car isn't started.");
            }
        }

        void IPetrolCar.Refuel()
        {
            if (petrolFuelState)
            {
                Console.WriteLine($"The car is already fueled with Petrol");
            }
            else
            {
                Console.WriteLine($"Refueling the car with Petrol");
                petrolFuelState = true;
            }
        }

        void IElectricCar.Refuel()
        {
            if (electricFuelState)
            {
                Console.WriteLine($"The car is already fueled with Electricity");
            }
            else
            {
                Console.WriteLine($"Charging the car with Electricity");
                electricFuelState = true;
            }
        }

    }
}
