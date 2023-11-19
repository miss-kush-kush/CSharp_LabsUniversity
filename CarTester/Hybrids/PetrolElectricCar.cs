using CarTester.Interfaces;
using CarTester.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Hybrids
{
    public class PetrolElectricCar: Car, IPetrolCar, IElectricCar
    {
        public bool SilnikSpalinowy { get; set; }
        public bool Bak { get; set; }//Bak
        public bool SilnikElektryczny { get; set; }
        public bool Akumulator { get; set; }//Akumulator 

        string? CarType => "PetrolElectric";

        public override void Refuel()
        {
            ((IPetrolCar)this).Refuel();
            ((IElectricCar)this).Refuel();
        }

        public override void Run()
        {
            if (SilnikElektryczny && SilnikSpalinowy)
            {

                if (Bak && Akumulator)
                {

                    Console.WriteLine($"The {CarType} car is running with Petrol and Electricity");
                    Akumulator = false;
                    Bak = false;

                }
                else if (!Bak && Akumulator)
                {

                    Console.WriteLine($"The {CarType} car si running with Electricity, no Petrol");
                    Akumulator = false;

                }
                else if (Bak && !Akumulator)
                {

                    Console.WriteLine($"The {CarType} car running with Petrol, no Electricity");
                    Bak = false;

                }
                else
                {
                    Console.WriteLine($"There is no electricity and Petrol in the {CarType} car");

                }

            }
            else if (!SilnikElektryczny && SilnikSpalinowy)
            {

                Console.WriteLine("Silnik Spalinowy is ON");

                if (Bak)
                {
                    Console.WriteLine($"The {CarType} car running with Petrol");
                    Bak = false;
                }
                else
                {
                    Console.WriteLine($"There is no Petrol in {CarType} car");
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
            ((IPetrolCar)this).Start();
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

        void IPetrolCar.Stop()
        {
            if (SilnikSpalinowy)
            {
                Console.WriteLine($"Stopping the {CarType} car on Petrol Engine");
                SilnikSpalinowy = false;
            }
            else
            {
                Console.WriteLine($"The {CarType} car is already stoped on Petrol Engine");
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

        void IPetrolCar.Start()
        {
            if (!SilnikSpalinowy)
            {
                Console.WriteLine($"Starting the {CarType} car on Petrol Engine");
                SilnikSpalinowy = true;
            }
            else
            {
                Console.WriteLine($"The Petrol car is already started on Petrol Engine");
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
