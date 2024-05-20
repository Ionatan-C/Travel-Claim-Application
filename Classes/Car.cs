using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_exam_v2.Classes
{
    class Car
    {
        private string registration;
        private int enginesize;
        private int mileage;
        private double carallowance = 9.25;
        string response;
        public Car()
        {

        }
        public string Registration
        {
            get
            {
                return registration;
            }
            set
            {
                registration = value;
            }
        }
        public int Enginesize
        {
            get
            {
                return enginesize;
            }
            set
            {
                enginesize = value;
            }
        }
        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                mileage = value;
            }
        }


        public string CarType()
        {
            Console.WriteLine("Enter Company car or Private car - C / P");
            response = Console.ReadLine();

            switch (response)
            {
                case "C":
                    Console.WriteLine(response);
                    break;

                case "P":
                    Console.WriteLine(response);
                    break;

                default:
                    Console.WriteLine("Please input Either C or P");
                    CarType();
                    break;
            }
            return response;
        }

        public void CorP()
        {
            string one = "P";

            if (response == one)
            {
                PetrolClaimPrivateCar();
            }
            else
            {
                PetrolClaimCompanyCar();
            }
        }

        public double PetrolClaimCompanyCar()
        {

            if (enginesize <= 1499)
            {
                double petrolclaim = mileage * 7.5 / 100;
                Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                double totalclaim = petrolclaim;
                Console.WriteLine("Your total claim is: £{0}", totalclaim);
            }
            else if (enginesize <= 1999)
            {
                double petrolclaim = mileage * 10 / 100;
                Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                double totalclaim = petrolclaim;
                Console.WriteLine("Your total claim is: £{0}", totalclaim);
            }
            else if (enginesize <= 2499)
            {
                double petrolclaim = mileage * 12.5 / 100;
                Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                double totalclaim = petrolclaim;
                Console.WriteLine("Your total claim is: £{0}", totalclaim);
            }
            else if (enginesize >= 2500)
            {
                double petrolclaim = mileage * 15 / 100;
                Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                double totalclaim = petrolclaim;
                Console.WriteLine("Your total claim is: £{0}", totalclaim);
            }



            return 0;
        }

        public double PetrolClaimPrivateCar()
        {

            if (enginesize <= 1499)
            {
                if (mileage <= 25)
                {
                    double petrolclaim = mileage * 30 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
                else
                {
                    double petrolclaim = mileage * 5 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
            }
            else if (enginesize <= 1999)
            {
                if (mileage <= 25)
                {
                    double petrolclaim = mileage * 30 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
                else
                {
                    double petrolclaim = mileage * 5 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
            }
            else if (enginesize <= 2499)
            {
                if (mileage <= 25)
                {
                    double petrolclaim = mileage * 30 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
                else
                {
                    double petrolclaim = mileage * 5 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
            }
            else if (enginesize >= 2500)
            {
                if (mileage <= 25)
                {
                    double petrolclaim = mileage * 30 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
                else
                {
                    double petrolclaim = mileage * 5 / 100;
                    Console.WriteLine("Your Petrol Claim is £{0}", petrolclaim);

                    double totalclaim = petrolclaim + carallowance;
                    Console.WriteLine("Your total claim is: £{0}", totalclaim);
                }
            }

            return 0;
        }


        public void printCarAllowance()
        {
            Console.WriteLine("Your private car allowance is: {0}", carallowance);
        }
        public void printEngineSize()
        {
            Console.WriteLine("Your engine size is: {0} CC", enginesize);
        }
        public void printMileage()
        {
            Console.WriteLine("You traveled: {0} miles", mileage);
        }
        public void printCarRegistration()
        {
            Console.WriteLine("Your car registration is: {0}", registration);
        }

    }
}
