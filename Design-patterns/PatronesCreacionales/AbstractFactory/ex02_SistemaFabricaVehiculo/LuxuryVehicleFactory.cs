using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class LuxuryVehicleFactory : VehicleFactory
    {
        public override ICarrocería CrearCarrocería()
        {
            return new LuxuryVehicleCarrocería("Carrocería de aluminio o fibra de carbono," +
                " diseño sofisticado, materiales premium.");
        }

        public override IMotor CrearMotor()
        {
            return new LuxuryVehicleMotor(" Motor de combustión interna de 6 cilindros," +
                " cilindrada de 3.0 litros, potencia de 300 caballos de fuerza.");
        }

        public override ITransmisión CrearTransmisión()
        {
            return new LuxuryVehicleTransmisión(" Transmisión automática de 8 velocidades," +
                " transmisión automática de doble embrague.");
        }
    }
}
