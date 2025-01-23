using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_2025
{
    internal class Program
    {
        class calculater
        {
            public void Sum(int num, int num1)
            {
                Console.WriteLine(num + num1);
            }


            public void Sum(int num, int num1, int num2)
            {
                Console.WriteLine(num + num1 + num2);
            }

            public void Sum(double num, double num1)
            {
                Console.WriteLine(num + num1);
            }
        }

        class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("Drawing a Shape");
            }
            
        }

        class Circle : Shape {
        
            public override void draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }

        class Rectangle : Shape 
        {
            public override void draw()
            {
                Console.WriteLine("Drawing a Rectangle");
            }
        }

        


         abstract class Animal {
            public abstract void makeSound();
            public void sleep() { 
                Console.WriteLine("Animal is Sleeping"); }

            }

        class Dog : Animal {
            public override void makeSound() {
                Console.WriteLine("Dog barks");
            }
        }


        class Cat : Animal {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }




        interface playable 
        {
            void play();
           
        }


        class Guitar : playable
        {
            public void play()
            {
                Console.WriteLine("Playing the Guitar.");
            }

        }


        class Piano : playable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano.");
            }

        }









        static void Main(string[] args)
        {
            //class calculater
            Console.WriteLine("Inside tha Class Caluclater");
            calculater cal = new calculater();
            cal.Sum(1, 2);
            cal.Sum(2, 3, 3);
            cal.Sum(2.3, 3.3);
            Console.WriteLine();


            //class shape
            Console.WriteLine("Inside the class Shape");
            Shape shape1 = new Shape();
            shape1.draw();
            Circle circle1 = new Circle();
            circle1.draw();
            Rectangle rectangle1 = new Rectangle();
            rectangle1.draw();
            Console.WriteLine();


            //class Animal
            Console.WriteLine("Inside the class Animal");
            Cat cat1 = new Cat();
            cat1.sleep();
            cat1.makeSound();

            Animal dog1 = new Dog();
            dog1.makeSound();
            dog1.sleep();


            Console.WriteLine();


            //class playable
            Console.WriteLine("Inside the class playable");
            Piano piano1 = new Piano();
            piano1.play();

            playable guitar1 = new Guitar();
            guitar1.play();


        }
    }
}
