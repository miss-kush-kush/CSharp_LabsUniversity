using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Interfaces
{
    public interface IPetrolCar:ICar
    {
        void RefuelPetrol();
        void RunPetrolCar();
    }
}
