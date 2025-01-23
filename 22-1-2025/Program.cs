using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22_1_2025
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void start()
            {
                Console.WriteLine("Vehicle is Starting");

            }
        }

        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

        }


        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            Car car1 = new Car();

            car1.Brand = "Toyota";
            car1.Model = "RV4";
            car1.NumberOfDoors = 4;
            vehicle1.start();

        }
    }
}


//1- What is constructor? a special method, that used to initalize fields or methods
//2- What are the basic concepts of OOPs? 1. Encapsulation 2. Inheritance  3. Abstraction 4. polymorphism
//3. What is the Encapsulation? 
//4- What is the sealed class? a way to prevent inheritance
//5- What is the Inheritance concept? shared the prpoerties between classes 
