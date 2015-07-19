using System;

namespace spikeApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : V4\n2 : V8\n3 : GLX");
            Console.WriteLine("Enter your choice for choosing a car-engine");
            var choice = Console.ReadLine();
            var carEngine = EngineFactory.GetCarEngine(choice);

            var newCar = new Car(carEngine);
            Console.WriteLine(newCar.GetSpecifications());
            Console.Read();
        }
    }
}
