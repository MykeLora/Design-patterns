using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    public class GamingRam: IRam
    {
        public int Capacidad {  get; set; }
        public GamingRam(int capacidad)
        {
            this.Capacidad = capacidad;
        }
    }
}
