namespace Ejercicio_Abstract_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComputerFactory factory = new BasicComputerFactory();
            Computer computer = new Computer(factory);

            Console.WriteLine("CPU: {0}", computer.Cpu.Velocidad.ToString());
            Console.WriteLine("RAM: {0}", computer.Ram.Capacidad.ToString());

            factory = new GamingComputerFactory();
            computer = new Computer(factory);

            Console.WriteLine("CPU: {0}", computer.Cpu.Velocidad.ToString())
            Console.WriteLine("RAM: {0}", computer.Ram.Capacidad.ToString());
        }
    }
    
    
}