using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarTester
{
    internal abstract class Car
    {
        protected bool Engine = false;
        protected bool FuelState = false;
        protected string? CarType { get; }
        protected string? FuelType { get; }

        internal void Start()
        {
            if(Engine)
            {
                WriteLine("The car is already Started");
            }
            else
            {
                WriteLine("Starting the car");
                Engine = true;
            }
        }

        internal void Stop()
        {
            if (Engine)
            {
                WriteLine("Stopping the car");
                Engine = false;
            }
            else
            {
                WriteLine("The car is already Stoped");
            }
        }

        internal abstract void Run();
        internal abstract void ReFuel();
    }
}
