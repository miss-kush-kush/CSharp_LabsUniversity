using CarTester.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Hybrids
{
    public class PetrolGasCar: ICar, IPetrolCar, IGasCar
    {
        private bool engineState = false;
        private bool petrolFuelState = false;
        private bool gasFuelState = false;
        private string carType = "PetrolGas";

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
            if (!petrolFuelState)
            {
                RefuelPetrol();
            }
            else if (!gasFuelState)
            {
                RefuelGas();
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
                if (petrolFuelState)
                {
                    RunPetrolCar();
                }
                else if (gasFuelState)
                {
                    RunGasCar();
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

        public void RefuelPetrol()
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

        public void RunPetrolCar()
        {
            if (engineState)
            {
                if (petrolFuelState)
                {
                    Console.WriteLine($"The {carType} car is running on Petrol");
                    petrolFuelState = false;
                }
                else
                {
                    Console.WriteLine($"There's no Petrol in the {carType} car");
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
    }
}
