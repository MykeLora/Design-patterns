using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    public class GamingCpu: ICpu
    {
        public int Velocidad {  get; set; }

        public GamingCpu(int velocidad)
        {
            Velocidad = velocidad;
        }   
    }
}
