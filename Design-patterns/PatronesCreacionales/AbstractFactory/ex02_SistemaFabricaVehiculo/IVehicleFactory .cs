using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    public interface IVehicleFactory
    {
        ICarrocería CrearCarrocería();
        IMotor CrearMotor();
        ITransmisión CrearTransmisión();

    }
       
}
