using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    class BasicVehicleMotor : IMotor
    {
        public string motor { get ; set ; }

        public BasicVehicleMotor(string motor)
        {
            this.motor = motor;
        }
    }
}
