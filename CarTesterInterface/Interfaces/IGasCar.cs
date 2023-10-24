using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester.Interfaces
{
    public interface IGasCar:ICar
    {
        void RefuelGas();
        void RunGasCar();
    }
}
