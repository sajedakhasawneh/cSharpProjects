using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_2025
{
    internal class Program
    {

        //task5
        static int min(int num, int num2)
        {
            if (num > num2)
                return num2;
            else return num;
        }



        //task6
        static double converttoMile(double num)
        {
            double result = num * 0.621371;
            return result;
        }


        //task7
        static int tominutes(int hour, int mint)
        {
            int minute = hour * 60;
            int total = minute + mint;
            return total;
        }


        //task8
        static string totalHoursMints(int min)
        {
            int hour = min / 60;
            int minute = min % 60;
            string time = hour + " Hours," + minute + " Minutes";
            return time;
        }



        //task9
        static string compareNum(int num, int num2)
        {
            string result;
            result = num > num2 ? "Greater" : num < num2 ? "Smaller" : "Equal";
            return result;

        }


        static int digitSum(int num)
        {
            int sum = 0;
            int rem;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            return sum;
        }




        static string Divisible(int num, int num2)
        {
            if (num % num2 == 0)
                return "Divisible";
            else
                return "Not Divisible";
        }

        static int midNum(int num, int num2, int num3)
        {
            int mid = 0;
            if (num2 > num && num > num3)
                mid = num;
            else if (num > num2 && num2 > num3)
                mid = num2;
            else
                mid = num3;

            return mid;
        }
        static int reversNum(int num)
        {
            int reverse = 0, rem;
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            return reverse;
        }



        static void Main(string[] args)
        {

            //task1
            //double num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Double: " + num);
            ////int numint = Convert.ToInt32(num);
            //Console.WriteLine("Converted Int: " + (int)num);





            //task2
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your number is: " + Convert.ToString(num));



            //task3
            //string sentence = Console.ReadLine();
            //Console.WriteLine("Uppercase: " + sentence.ToUpper());
            //Console.WriteLine("Lowercase: " + sentence.ToLower());


            //task4
            //string firstName = Console.ReadLine();
            //string lastName = Console.ReadLine();
            //string fullName = firstName +" " + lastName;
            //Console.WriteLine("First Name:" + firstName );
            //Console.WriteLine("Last Name:" + lastName);

            //Console.WriteLine(fullName.Length);



            //task5

            //Console.WriteLine("Smaller is :" + min(5, 9));



            //task6
            //double inKm = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(converttoMile(inKm) + " mph");


            //task7
            //int hours= Convert.ToInt32(Console.ReadLine());
            //int minutes= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Total:"+ tominutes(hours,minutes)+ "minutes");



            //task8
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(totalHoursMints(minutes));




            //task9
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(compareNum(num, num2));   



            //task9.2
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(digitSum(num));



            //task10
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(reversNum(num));



            //task11
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Divisible(num, num2));


            //task12
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(midNum(num, num2, num3));


        }


    }
}











