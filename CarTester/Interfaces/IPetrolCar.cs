using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Interfaces
{
    public interface IPetrolCar
    {
        bool SilnikSpalinowy { get; set; }
        bool Bak { get; set; }

        void Start();

        void Stop();

        void Refuel();

        void Run();
    }
}
