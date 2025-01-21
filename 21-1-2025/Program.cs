using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_2025
{
    internal class Program
    {
        class Student
        {

            private int id;
            private string name;
            private int age;

            public const int minAge = 18;
            public const int maxAge = 40;


            public string Name {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public int Age {

                get
                {
                    return age;
                }
                set
                {
                    if (value < 18)
                        age = 18;
                    else
                        age = value;
                }
            }
            public int ID {
                get
                {
                    return id;
                }
                set
                {
                    if (value == 0)
                        this.id = 1; 
                    else
                        this.id = value;
                }
            }
            public string Email { get; set; }


            public void GetDetails()
            {
                Console.WriteLine("The student name is " + Name + " ,the age is " + Age + " and the student ID is " + ID);
               
            }

            public Student() { }
            public Student(string Name, int Age, int ID)
            {
                this.Name = Name;
                this.Age = Age;
                this.ID = ID;

            }

            ~Student() {
                Console.WriteLine("Program End");
            }



        }
            static void Main(string[] args)
            {
                Student student1 = new Student();
                student1.Name = "Ahmad";
                student1.Age = 17;
                student1.ID = 1001;

                student1.GetDetails();

                Student student2 = new Student("mhmd", 20, 1005);
                student2.GetDetails();

        }
        }
    }

