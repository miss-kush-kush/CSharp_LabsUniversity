using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTester.Interfaces;
using CarTester.Normal;

namespace CarTester.Hybrids
{
    public class GasElectricCar: Car, IGasCar, IElectricCar
    {
        private bool gasFuelState = false;
        private bool electricFuelState = false;
        string? CarType => "GasElectric";

        public override void Refuel()
        {
            ((IGasCar)this).Refuel();
            ((IElectricCar)this).Refuel();
        }

        public override void Run()
        {
            if (EngineState)
            {
                if (gasFuelState)
                {
                    Console.WriteLine($"The {CarType} car is running on Gas");
                    gasFuelState = false;
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
