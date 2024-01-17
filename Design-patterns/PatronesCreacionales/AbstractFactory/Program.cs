using Design_patterns.PatronesCreacionales.AbstractFactory.ex02_SistemaFabricaVehiculo;
using Ejercicio_Abstract_factory;

namespace Design_patterns.PatronesCreacionales.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new BasicVehicleFactory();
            Vehiculo vehiculo = new Vehiculo(factory);

            Console.WriteLine("Vehiculo Gama Baja");
            Console.WriteLine("Motor: {0}", vehiculo.Motor.motor.ToString());
            Console.WriteLine("Transmisión: {0}", vehiculo.Transmisión.Tipo.ToString());
            Console.WriteLine("Carrocería: {0}", vehiculo.Carrocería.Tipo.ToString());
            Console.WriteLine("-------------------------------------------------------");

            factory = new LuxuryVehicleFactory();
            vehiculo = new Vehiculo(factory);

            Console.WriteLine("Vehiculo Alta Gama");
            Console.WriteLine("Motor: {0}", vehiculo.Motor.motor.ToString());
            Console.WriteLine("Transmisión: {0}", vehiculo.Transmisión.Tipo.ToString());
            Console.WriteLine("Carrocería: {0}", vehiculo.Carrocería.Tipo.ToString());
        }
    }

}