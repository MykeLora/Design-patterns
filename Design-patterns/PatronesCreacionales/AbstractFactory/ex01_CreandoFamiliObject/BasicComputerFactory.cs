using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    class BasicComputerFactory : ComputerFactory
    {
        public override ICpu CrearCpu()
        {
            return new BasicCpu(5);
        }

        public override IRam CrearRam()
        {
            return new BasicRam(8);
        }
    }
}
