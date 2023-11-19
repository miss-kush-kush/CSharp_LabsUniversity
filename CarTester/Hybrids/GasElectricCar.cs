using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTester.Interfaces;
using CarTester.Normal;

namespace CarTester.Hybrids
{
    public class GasElectricCar : Car, IGasCar, IElectricCar
    {

        public bool SilnikSpalinowy { get; set; }
        public bool Butla { get; set; }//Butla
        public bool SilnikElektryczny { get; set; }
        public bool Akumulator { get; set; }//Akumulator 

        string? CarType => "GasElectric";

        public override void Refuel()
        {
            ((IGasCar)this).Refuel();
            ((IElectricCar)this).Refuel();
        }

        public override void Run()
        {
            if (SilnikElektryczny && SilnikSpalinowy)
            {

                if (Butla && Akumulator)
                {

                    Console.WriteLine($"The {CarType} car is running with Gas and Electricity");
                    Akumulator = false;
                    Butla = false;

                }
                else if (!Butla && Akumulator)
                {

                    Console.WriteLine($"The {CarType} car si running with Electricity, no Gas");
                    Akumulator = false;

                }
                else if (Butla && !Akumulator)
                {

                    Console.WriteLine($"The {CarType} car running with Gas, no Electricity");
                    Butla = false;

                }
                else
                {
                    Console.WriteLine($"There is no electricity and Gas in the {CarType} car");

                }

            }
            else if (!SilnikElektryczny && SilnikSpalinowy)
            {

                Console.WriteLine("Silnik Spalinowy is ON");

                if (Butla)
                {
                    Console.WriteLine($"The {CarType} car running with Gas");
                    Butla = false;
                }
                else
                {
                    Console.WriteLine($"There is no Gas in {CarType} car");
                }

            }
            else if (SilnikElektryczny && !SilnikSpalinowy)
            {

                Console.WriteLine("Silnik Elektryczny is ON");

                if (Akumulator)
                {
                    Console.WriteLine($"The {CarType} car running with electricity");
                    Akumulator = false;
                }
                else
                {
                    Console.WriteLine($"There is no Electricity in {CarType} car");
                }

            }
            else
            {
                Console.WriteLine($"The {CarType} car hasn`t started AT ALL");
            }


        }

        public new void Start()
        {
            Console.WriteLine($"Starting the {CarType} car");
            ((IGasCar)this).Start();
            ((IElectricCar)this).Start();
        }

        public new void Stop()
        {
            Console.WriteLine($"Stoping the {CarType} car");
            ((IElectricCar)this).Stop();
            SilnikElektryczny = false;
        }


        void IElectricCar.Stop()
        {
            if (SilnikElektryczny)
            {
                Console.WriteLine($"Stopping the {CarType} car on Electrical Engine");
                SilnikElektryczny = false;
            }
            else
            {
                Console.WriteLine($"The {CarType} car is already stoped on Electrical Engine");
            }
        }

        void IGasCar.Stop()
        {
            if (SilnikSpalinowy)
            {
                Console.WriteLine($"Stopping the {CarType} car on Gas Engine");
                SilnikSpalinowy = false;
            }
            else
            {
                Console.WriteLine($"The {CarType} car is already stoped on Gas Engine");
            }
        }

        void IElectricCar.Start()
        {
            if (!SilnikElektryczny)
            {
                Console.WriteLine($"Starting the {CarType} car on Electrical Engine");
                SilnikElektryczny = true;
            }
            else
            {
                Console.WriteLine($"The {CarType} car is already started on Electrical Engine");
            }
        }

        void IGasCar.Start()
        {
            if (!SilnikSpalinowy)
            {
                Console.WriteLine($"Starting the {CarType} car on Gas Engine");
                SilnikSpalinowy = true;
            }
            else
            {
                Console.WriteLine($"The Gas car is already started on Gas Engine");
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
                Butla = true;
            }
        }

        void IElectricCar.Refuel()
        {
            if (Akumulator)
            {
                Console.WriteLine($"The car is already fueled with Electricity");
            }
            else
            {
                Console.WriteLine($"Charging the car with Electricity");
                Akumulator = true;
            }
        }
    }
}
