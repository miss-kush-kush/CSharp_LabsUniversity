using CarTester.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarTester.Normal
{
    public class ElectricCar : Car, IElectricCar
    {
        public bool SilnikElektryczny
        {
            get { return EngineState; }
            set { EngineState = value; }
        }

        public bool Akumulator
        {
            get { return FuelState; }
            set { FuelState = value; }
        }

        string? CarType => "Electric";
        string? FuelType = "Electricity";

        public override void Refuel()
        {
            if (Akumulator)
            {

                WriteLine($"The car is already Fueled with {FuelType}");

            }
            else
            {
                WriteLine($"ReFueling the car with {FuelType}");
                Akumulator = true;
            }
        }

        public override void Run()
        {
            if (SilnikElektryczny)
            {
                if (Akumulator)
                {
                    WriteLine($"The {CarType} car is running");
                    Akumulator = false;
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
