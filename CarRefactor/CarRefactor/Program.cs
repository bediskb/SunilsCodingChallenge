using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    class Program
    {
        /// <summary>
        /// This application violate the SOLID design principle, that's why it's got exception, use the best of your refactoring skill to refactor this code to comply SOLID design principle
        /// You're welcome to add as many as class you want to solve the problem
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
             /*var cars = new List<Car>
             {
                 new Mercedes(2017,"GLS 63 AMG"),
                 new Toyota(2002,"Corolla GX"),
             };
             foreach (var car in cars)
             {
                 car.TurnOnHeatedChairMassage();
                 car.Accelerate();
             }*/
            Car Mercedes = new Car(args[0], args[1]);

            Mercedes.TurnOnHeatedChairMassage();
            Mercedes.Accelerate();

            Console.WriteLine("Arguments received:\t" + args[0] + "\t" + args[1]);
            //Console.ReadKey();

            
        }
    }

    class Car
    {
        public string model;
        public int year;
        private string v1;
        private string v2;

        public Car(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public void TurnOnHeatedChairMassage()
        {
            //some code here
            Console.WriteLine("TurnOnHeatedChairMassage() method executed for object");
            Console.ReadKey();
        }

        public void Accelerate()
        {
            //some code here
            Console.WriteLine("Accelerate() method executed for object");
            Console.ReadKey();
        }

    }
}
