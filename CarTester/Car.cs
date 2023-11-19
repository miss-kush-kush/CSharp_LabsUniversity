using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTester.Interfaces;
using static System.Console;

namespace CarTester
{
    public abstract class Car: ICar
    {
        protected bool EngineState = false;
        protected bool FuelState = false;
        protected string? CarType { get; }
        protected string? FuelType { get; }

        public void Start()
        {
            if (EngineState)
            {
                WriteLine("The car is already Started");
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
                WriteLine("The car is already Stoped");
            }
        }

        public abstract void Run();
        public abstract void Refuel();
    }
}
