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
        public bool SilnikSpalinowy
        {
            get { return EngineState; }
            set { EngineState = value; }
        }

        public bool Butla
        {
            get { return FuelState; }
            set { FuelState = value; }
        }

        string? CarType => "Gas";
        string? FuelType = "Gas";

        public override void Refuel()
        {
            if (Butla)
            {

                WriteLine($"The car is already Fueled with {FuelType}");

            }
            else
            {
                WriteLine($"ReFueling the car with {FuelType}");
                Butla = true;
            }
        }

        public override void Run()
        {
            if (SilnikSpalinowy)
            {
                if (Butla)
                {
                    WriteLine($"The {CarType} car is running");
                    Butla = false;
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
