using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CarTester.Interfaces;
using Microsoft.VisualBasic.FileIO;

namespace CarTester.Normal
{
    public class PetrolCar : ICar, IPetrolCar
    {
        private bool EngineState = false;
        private bool FuelState = false;

        private string CarType = "Petrol";
        private string FuelType = "Petrol";

        public void Start()
        {
            if (EngineState)
            {
                WriteLine("The car is already running");
            }
            else
            {
                WriteLine("Starting the car");
                EngineState = true;
            }
        }

        public void Stop()
        {
            if (EngineState)
            {
                WriteLine("Stopping the car");
                EngineState = false;
            }
            else
            {
                WriteLine("The car is already off");
            }
        }

        public void Refuel()

        {
            RefuelPetrol();
        }

        public void Run()
        {
            RunPetrolCar();
        }

        public void RefuelPetrol()
        {
            if (FuelState)
            {

                WriteLine($"The car is already fueled with {FuelType}");

            }
            else
            {
                WriteLine($"Refueling the car with {FuelType}");
                FuelState = true;
            }
        }

        public void RunPetrolCar()
        {
            if (EngineState)
            {
                if (FuelState)
                {
                    WriteLine($"The {CarType} car is running");
                    FuelState = false;
                }
                else
                {
                    WriteLine($"There`s no {FuelType} in {CarType} car ");
                }
            }
            else
            {
                WriteLine("The car isn`t Started");
            }
        }

    }
}
