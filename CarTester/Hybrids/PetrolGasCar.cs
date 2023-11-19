using CarTester.Interfaces;
using CarTester.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Hybrids
{
    public class PetrolGasCar: Car, IPetrolCar, IGasCar
    {
        private bool petrolFuelState = false;
        private bool gasFuelState = false;
        string? CarType => "PetrolGas";

        public override void Refuel()
        {
            ((IPetrolCar)this).Refuel();
            ((IGasCar)this).Refuel();
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
                else if (gasFuelState)
                {
                    Console.WriteLine($"The {CarType} car is running on Gas");
                    gasFuelState = false;
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
                FuelState = true;
            }
        }

        void IGasCar.Refuel()
        {
            if (gasFuelState)
            {
                Console.WriteLine($"The car is already fueled with Gas");
            }
            else
            {
                Console.WriteLine($"Refueling the car with Gas");
                gasFuelState = true;
                FuelState = true;
            }
        }

    }
}
