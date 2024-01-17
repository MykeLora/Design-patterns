using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo
{
    public class Main
    {
        public static void main(string[] args)
        {
            IVehicleFactory factory = new BasicVehicleFactory();
            Vehiculo vehiculo = new Vehiculo(factory);

            Console.WriteLine("Vehiculo Gama Baja");
            Console.WriteLine("Motor: {0}", vehiculo.Motor.motor);
            Console.WriteLine("Transmisión: {0}", vehiculo.Transmisión.Tipo);
            Console.WriteLine("Carrocería: {0}", vehiculo.Carrocería.Tipo);

            factory = new LuxuryVehicleFactory();
            vehiculo = new Vehiculo(factory);

            Console.WriteLine("Vehiculo Alta Gama");
            Console.WriteLine("Motor: {0}", vehiculo.Motor.motor);
            Console.WriteLine("Transmisión: {0}", vehiculo.Transmisión.Tipo);
            Console.WriteLine("Carrocería: {0}", vehiculo.Carrocería.Tipo);

        }

    }
}
