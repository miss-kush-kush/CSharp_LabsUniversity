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
    public class PetrolCar : Car, IPetrolCar
    {
        public bool SilnikSpalinowy
        {
            get { return EngineState; }
            set { EngineState = value; }
        }

        public bool Bak
        {
            get { return FuelState; }
            set { FuelState = value; }
        }
        string? CarType => "Petrol";
        string? FuelType = "Petrol";

        public override void Refuel()
        {
            if (Bak)
            {

                WriteLine($"The car is already Fueled with {FuelType}");

            }
            else
            {
                WriteLine($"ReFueling the car with {FuelType}");
                Bak = true;
            }
        }

        public override void Run()
        {
            if (SilnikSpalinowy)
            {
                if (Bak)
                {
                    WriteLine($"The {CarType} car is running");
                    Bak = false;
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
