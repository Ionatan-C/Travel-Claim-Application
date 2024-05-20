using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_exam_v2.Classes
{
    class ReplayCalculator
    {
        public int Replay()
        {
            Console.WriteLine("Would you like to go again Y for Yes or N for No");
            string result = Console.ReadLine();

            switch (result)
            {
                case "Y":
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

                    break;

                case "N":
                    Console.WriteLine("Thank you for using the WorcWheelz Calculator");
                    return 0;

                default:
                    Console.WriteLine("Please input either Y for yes or N for no.");
                    Replay();
                    break;
            }
            return 0;
        }
    }
}
