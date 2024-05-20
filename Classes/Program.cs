using System;

namespace Mock_exam_v2.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Journey journey = new Journey();
            ReplayCalculator replay = new ReplayCalculator();

            Console.WriteLine("Enter car registration");
            car.Registration = Console.ReadLine();

            Console.WriteLine("Enter journey start location");
            journey.LocationStart = Console.ReadLine();

            Console.WriteLine("Enter journey end location");
            journey.LocationEnd = Console.ReadLine();

            Console.WriteLine("Enter engine size in CC (eg 1500)");
            car.Enginesize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mileage");
            car.Mileage = Convert.ToInt32(Console.ReadLine());

            car.CarType();

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("WorcsWheelz Travel Claim Calculator");

            car.printCarRegistration();

            journey.printLocationStartandEnd();

            car.printEngineSize();

            car.printMileage();

            car.CorP();

            replay.Replay();
        }
    }
}
