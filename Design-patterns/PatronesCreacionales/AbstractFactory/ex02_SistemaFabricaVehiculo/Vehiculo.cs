using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class Vehiculo
    {
        private IMotor motor;
        private ICarrocería carrocería;
        private ITransmisión transmisión;

        public Vehiculo(IVehicleFactory factory)
        {
            motor = factory.CrearMotor();
            transmisión = factory.CrearTransmisión();
            carrocería = factory.CrearCarrocería();
        }

        public IMotor Motor { get { return motor; } }

        public ITransmisión Transmisión { get { return transmisión; } }

        public ICarrocería Carrocería { get { return carrocería; } }
    }
}
