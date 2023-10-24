using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTester.Interfaces;

namespace CarTester.Hybrids
{
    public class GasElectricCar: ICar, IGasCar, IElectricCar
    {
        private bool engineState = false;
        private bool gasFuelState = false;
        private bool electricFuelState = false;
        private string carType = "GasElectric";

        public void Start()
        {
            if (engineState)
            {
                Console.WriteLine("The car is already running");
            }
            else
            {
                Console.WriteLine("Starting the car");
                engineState = true;
            }
        }

        public void Stop()
        {
            if (engineState)
            {
                Console.WriteLine("Stopping the car");
                engineState = false;
            }
            else
            {
                Console.WriteLine("The car is already off");
            }
        }

        public void Refuel()
        {
            if (!gasFuelState)
            {
                RefuelGas();
            }
            else if (!electricFuelState)
            {
                ChargeBatteries();
            }
            else
            {
                Console.WriteLine("No fuel available for the car.");
            }
        }

        public void Run()
        {
            if (engineState)
            {
                if (gasFuelState)
                {
                    RunGasCar();
                }
                else if (electricFuelState)
                {
                    RunElectricCar();
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

        public void RefuelGas()
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

        public void RunGasCar()
        {
            if (engineState)
            {
                if (gasFuelState)
                {
                    Console.WriteLine($"The {carType} car is running on Gas");
                    gasFuelState = false;
                }
                else
                {
                    Console.WriteLine($"There's no Gas in the {carType} car");
                }
            }
            else
            {
                Console.WriteLine("The car isn't started.");
            }
        }

        public void ChargeBatteries()
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

        public void RunElectricCar()
        {
            if (engineState)
            {
                if (electricFuelState)
                {
                    Console.WriteLine($"The {carType} car is running on Electricity");
                    electricFuelState = false;
                }
                else
                {
                    Console.WriteLine($"There's no Electricity in the {carType} car");
                }
            }
            else
            {
                Console.WriteLine("The car isn't started.");
            }
        }
    }
}
