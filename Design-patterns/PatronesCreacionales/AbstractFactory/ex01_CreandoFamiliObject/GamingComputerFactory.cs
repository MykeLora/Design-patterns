using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    class GamingComputerFactory : ComputerFactory
    {
        public override ICpu CrearCpu()
        {
            return new GamingCpu(9);
        }

        public override IRam CrearRam()
        {
            return new GamingRam(16);
        }
    }
}
