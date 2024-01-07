using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Abstract_factory
{
    public class Computer
    {
        private ICpu cpu;
        private IRam ram;


        public Computer(IComputerFactory factory)
        {
            this.cpu = factory.CrearCpu();
            this.ram = factory.CrearRam();
        }

        public ICpu Cpu {  get { return this.cpu; } }

        public IRam Ram { get { return this.ram; } }

    }
}
