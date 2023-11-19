using CarTester.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarTester.Normal
{
    public class GasCar : Car, IGasCar
    {
        string? CarType => "Gas";
        string? FuelType = "Gas";

        public override void Refuel()
        {
            if (FuelState)
            {

                WriteLine($"The car is already Fueled with {FuelType}");

            }
            else
            {
                WriteLine($"ReFueling the car with {FuelType}");
                FuelState = true;
            }
        }

        public override void Run()
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
