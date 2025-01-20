using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string OddEvenNums(int num)
        {
            string result;
            if (num % 2 == 0)
            {
                result = "The number " + num + " is even.";
                return result;
            }
            else {
                result = "The number " + num + " is odd.";
                return result;  
            }
        }


        //task2
        static int secondSmallest(int len)
        {
            Console.WriteLine("Enter the numbers of the array");
            int[] nums = new int[len];
            for (int i = 0; i<nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());

                }
            Array.Sort(nums);
            int smallest = nums[1];
            return smallest;
        }


        //task3 
        static int factorialNum(int num)
        {
            int result = 1;
            for (int i = num; i> 0; i--){
                result *= i;   
            }

            return result;
        }



        //task4
        //static int[] primeNums(int num1, int num2)
        //{
        //    int[] prime;
        //    for (int i = num1; num2 >= num1; i++)
        //    {
        //        if (num1 % i == 0) {
        //            continue; }
        //        else {
                    
        //        }

        //    }

        //}


        //task5
        static int largestNum(int len)
        {
            Console.WriteLine("Enter the numbers of the array");
            int max = -10000;
            int[] nums = new int[len];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < nums.Length - 1; i++) {
                if (nums[i] > max) { 
                    max = nums[i];
                }

                }
            return max;
        }

        //task6
        //static void patternShap(int row)
        //{
        //    int num = 1;
        //    for (int i = 1; i <= row; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(num++ + " ");

        //        }
        //    Console.WriteLine();
        //    }
        //}
        






        //class task
        class hotelystem {
           public int roomNum;
           public string roomtype;
           public double price;
           public bool isBooked;
           public const string hotelName = "Grand Stay Hotel";
        }

        static void Main(string[] args)
        {
            //task1
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(OddEvenNums(num));


            //task2
            //Console.WriteLine("Enter The length of the array");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(secondSmallest(num));



            //task3
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(factorialNum(num));


            //task4


            //task5
            //Console.WriteLine("Enter The length of the array");
            //int arrlength = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(largestNum(arrlength));



            //task7
            //patternShap(5);


       



            //classTask
            hotelystem room1 = new hotelystem();
            room1.roomNum = 15;
            room1.roomtype = "Single";
            room1.price = 150.70;
            room1.isBooked = false;


            hotelystem room2 = new hotelystem();    
            room2.roomNum = 230;
            room2.roomtype = "suit";
            room2.price = 350;
            room2.isBooked = true;



            Console.WriteLine("Room Number " + room1.roomNum + " is a " + room1.roomtype + " and the price of this room is " + room1.price + " is " + room1.isBooked);

            Console.WriteLine("Room Number " + room2.roomNum + " is a " + room2.roomtype + " and the price of this room is " + room2.price + " is " + room2.isBooked);
        }
    }
}