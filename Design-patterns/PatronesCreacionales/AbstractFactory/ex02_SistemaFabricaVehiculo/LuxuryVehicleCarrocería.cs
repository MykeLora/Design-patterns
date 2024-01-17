using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class LuxuryVehicleCarrocería : ICarrocería
    {
        public string Tipo { get; set; }

        public LuxuryVehicleCarrocería(string Tipo)
        {
            this.Tipo = Tipo;
        }
    }
}
