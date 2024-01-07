using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    public class BasicCpu: ICpu
    {
        public int Velocidad {  get; set; }

        public BasicCpu(int velocidad)
        {
            this.Velocidad = velocidad;
        }
    }
}
