using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class BasicVehicleFactory : VehicleFactory
    {
        public override ICarrocería CrearCarrocería()
        {
            return new BasicVehicleCarrocería("Carrocería de acero," +
                " diseño sencillo, materiales económicos.");
        }

        public override IMotor CrearMotor()
        {
            return new BasicVehicleMotor("Motor de combustión interna de 6 cilindros," +
                " cilindrada de 3.0 litros, potencia de 300 caballos de fuerza.");
        }

        public override ITransmisión CrearTransmisión()
        {
            return new BasicVehicleTransmisión("Transmisión manual de 5 velocidades," +
                " transmisión automática de 4 velocidades.");
        }
    }
}
