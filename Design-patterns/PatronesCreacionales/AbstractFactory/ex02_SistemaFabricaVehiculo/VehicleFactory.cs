using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    public abstract class VehicleFactory : IVehicleFactory
    {
        public abstract ICarrocería CrearCarrocería();

        public abstract IMotor CrearMotor();

        public abstract ITransmisión CrearTransmisión();
        
    }
}
