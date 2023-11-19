using CarTester.Interfaces;
using CarTester.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Hybrids
{
    public class PetrolGasCar: Car, IPetrolCar, IGasCar
    {

        public bool SilnikSpalinowy
        {
            get { return EngineState; }
            set { EngineState = value; }
        }
        public bool Bak { get; set; }
        public bool Butla { get; set; }

        string? CarType => "PetrolGas";

        public override void Refuel()
        {
            ((IPetrolCar)this).Refuel();
            ((IGasCar)this).Refuel();
        }

        public override void Run()
        {
            if (SilnikSpalinowy)
            {

                if (Bak && Butla)
                {

                    Console.WriteLine($"The {CarType} car running with Petrol and Gas");
                    Butla = false;
                    Bak = false;

                }
                else if (!Bak && Butla)
                {

                    Console.WriteLine($"The {CarType} car running with Gas, no Petrol");
                    Butla = false;

                }
                else if (Bak && !Butla)
                {

                    Console.WriteLine($"The {CarType} car running with Petrol, no Gas");
                    Bak = false;

                }
                else
                {
                    Console.WriteLine($"There is no gas and petrol in the {CarType} car");

                }

            }
            else
            {
                Console.WriteLine($"The {CarType} car hasn`t started");
            }

        }

        void IPetrolCar.Refuel()
        {
            if (Bak)
            {
                Console.WriteLine($"The car is already fueled with Petrol");
            }
            else
            {
                Console.WriteLine($"Refueling the car with Petrol");
                Bak = true;
            }
        }

        void IGasCar.Refuel()
        {
            if (Butla)
            {
                Console.WriteLine($"The car is already fueled with Gas");
            }
            else
            {
                Console.WriteLine($"Refueling the car with Gas");
                Bak = true;
            }
        }

    }
}
