using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    public interface IComputerFactory
    {
        ICpu CrearCpu();
        IRam CrearRam();
    }
}
