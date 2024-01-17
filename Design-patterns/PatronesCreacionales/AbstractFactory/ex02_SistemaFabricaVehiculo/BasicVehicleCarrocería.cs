using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class BasicVehicleCarrocería : ICarrocería
    {
        public string Tipo { get; set; }

        public BasicVehicleCarrocería(string tipo)
        {
            this.Tipo = tipo;
        }
    }
}
