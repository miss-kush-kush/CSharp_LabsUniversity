using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Interfaces
{
    public interface IElectricCar:ICar
    {
        void Start();

        void Stop();

        void Refuel();

        void Run();
    }
}
