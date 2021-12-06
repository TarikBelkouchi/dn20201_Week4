using System;
using System.Collections.Generic;


namespace VirtualDemo
{

    class Car
    {
        public string Make;
        public string Model;
        public int GasAmount;

        public virtual void Drive()
        {
            Console.WriteLine("I'm driving!");
        }
    }


    class EconomyCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I'm driving slowly!");
        }
        
    }

    class RaceCar : Car
    {
        public override void Drive()
        {
            int SuperchargerSize;
            Console.WriteLine("I'm driving really fast") ;
        }
    }


    class Program
    {
        public static void TestTrack(Car testCar)
        {

            //This is polymprphism in action.
            // the computer will call the correct version of Drive
            //Downside We only know this is car
            //So if we pass in a Racecar, we cannot ceck the value of SuperchargerSize.
            Console.WriteLine("\nWe're at the test track!");
            Console.WriteLine($"We're testing a {testCar.Model}!");
            testCar.Drive();
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            EconomyCar pinto = new EconomyCar();
            pinto.Make = "Ford";
            pinto.Model = "Pinto";
            pinto.GasAmount = 10;
            Console.WriteLine("Let's drive the pinto");
            pinto.Drive();


            RaceCar f1 = new RaceCar();
            f1.Make = "Formula";
            f1.Model = "One";
            f1.GasAmount = 30;
            Console.WriteLine("\nLet's drive the f1");
            f1.Drive();

            List<Car> cars = new List<Car>();
            cars.Add(pinto);
            cars.Add(f1);
            

            Car mycar;
            mycar = pinto;
            Console.WriteLine("\nmycar will point to pinto");
            Console.WriteLine(mycar.Model);
            mycar.Drive();// The code called the right version of Drive. This is "polymorphism".

            mycar = f1;
            Console.WriteLine("\nmycar will point to f1");
            Console.WriteLine(mycar.Model);
            mycar.Drive();

            TestTrack(pinto);
            TestTrack(f1);
        }
    }
}
