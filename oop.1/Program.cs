using System.Data;
using System.Reflection;
using static oop._1.Program;

namespace oop._1
{
    internal class Program
    {
        #region Demo class
        //public static void DoSomeCode()
        //{//try catch 
        // //last defence line
        //    try
        //    {
        //        int x, y, z;
        //        Console.Write("please enter value of x:");
        //        x = int.Parse(Console.ReadLine());
        //        Console.Write("please enter value of y:");
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y;

        //        int[] Numbers = { 1, 2, 3 };
        //        Numbers[100] = 33;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }


        //}
        //public static void DoSomeProtictiveCode()
        //{
        //    try
        //    {
        //        int x, y, z;

        //        do
        //        {
        //            Console.WriteLine("Please enter value of x:");

        //        } while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("Please enter value of y:");

        //        } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);
        //        z = x / y;
        //        int[] arr = { 1, 2, 3 };

        //        if (arr?.Length > 100)
        //        {
        //            arr[100] = 90;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        //enum Gender
        //{
        //    Male = 1, Female = 2, male = 1, female = 2
        //}
        //enum Days : int
        //{
        //    Satarday,
        //    Sunday,
        //    Mounday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday
        //}
        //enum Grades
        //{
        //    A, B, C, D, E, F
        //}
        //enum Roles
        //{
        //    Admin = 10,
        //    Viewer = 20,
        //    Editor = 30
        //}
        //enum Branches : byte//0:255
        //{
        //    NaserCity, Maadi = 251, Alex, Doki, Elnahas, SmartVillage

        //}
        //[Flags]
        //enum Permissions : byte
        //{
        //    Delete = 1, Eecute = 2, Read = 4, Write = 8
        //}

        //class Employee
        //{
        //    public string Name;
        //    public int Age;
        //    public decimal Salary;
        //    public Gender Gender;//MAle - Female
        //    public Roles Roles;
        //    public Permissions Permissions;
        //}
        #endregion 
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        };
        public enum Seasons
        {
            spring,
            summer,
            autumn,
            winter,
        };

        [Flags]
        enum Permissions : byte
        {
            Delete = 1, Eecute = 2, Read = 4, Write = 8
        }
        class Employee
        {
            public string Name;
            public int Age;
            public decimal Salary;
            public Permissions Permissions;
        }
        public enum Colors
        {
            Red,
            Green,
            Blue,
        };
        static void Main(string[] args)
        {

            #region Demo Main

            #region Excertion handling
            //Exception HAndling => Run time eror
            //DoSomeCode();
            //Console.WriteLine("ayman");
            //FormatException
            //DivideByZeroException
            //Exception => Father class of all exception
            //System Exception
            //1)Format Exception
            //2)Index Out Of Range Exception
            //3)Null Reference
            //4)Arthimitic Exception
            //5)Invalid Operation exception
            //Application Exception
            //try
            //{
            //    DoSomeProtictiveCode();//Try code
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);//Error
            //}
            //finally
            //{
            //    //[Realsed,Deallocate,Delete,Close]
            //    //External Resource
            //}
            #endregion
            #region Access Modiofieers
            //TypeA typeA = new TypeA();


            #endregion
            #region Enums
            #region Ex01
            //string Day = "Hamada";
            //Days days = Days.Sunday;
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            #endregion
            #region Ex02
            //Grades grades = (Grades)2;//Explicit casting 
            //Console.WriteLine(grades);//c

            //Grades grades = (Grades)10;//Explicit casting
            //Console.WriteLine(grades);//10
            //Admin Viewr Editor

            #endregion
            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(Result);


            #endregion
            #region Ex04
            string Gender = "male";
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object result);
            //Console.WriteLine(result);
            //Enum.TryParse<Gender>(Gender, true, out Gender result);



            #endregion

            #endregion
            #region Permissions With Enum
            // #region Permisions
            // Employee Employee = new Employee();
            // Employee.Name = "Ali";
            // Employee.Salary = 2000;
            // Employee.Age= 30;
            // Employee.Permissions = (Permissions)3;
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            ////XOR ^
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            // Console.WriteLine(Employee.Permissions);//Delete Execute Read
            // Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            // Console.WriteLine(Employee.Permissions);//Delete Execute
            // //& AND
            // if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            // {
            //     Console.WriteLine("permision already exsist");
            // }
            // else
            // {
            //     Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //     Console.WriteLine(Employee.Permissions);
            // }
            // // Or |
            // //use to check for permission
            // Employee.Permissions= Employee.Permissions | Permissions.Write;
            // Console.WriteLine(Employee.Permissions); 
            #endregion
            #region Struct
            //Point p01;
            ////p01.x = 10;
            ////p01.y = 20;
            ////Console.WriteLine(p01.x);//invalid you must assign avalue before
            ////Console.WriteLine(p01.y);//invalid you must assign avalue before
            ////use construcor to assign the values
            //p01 = new Point(2,7);
            ////Console.WriteLine(p01.x);
            ////Console.WriteLine(p01.y);
            //Console.WriteLine(p01.ToString());//Assignment6.Point,bestway
            //Console.WriteLine(p01);//boking and un boking
            //Point p02= new();
            #endregion

            #endregion

            #region Assignment.1 OOP

            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //{
            //    Console.WriteLine("Days of the week:");
            //    foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //    {
            //        Console.WriteLine(day);
            //    }
            //}
            #endregion

            #region 2.Create an enum called "Season" with the four seasons (spring, summer, autumn, winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Seasons season))
            //{
            //    switch (season)
            //    {
            //        case Seasons.spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Seasons.summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Seasons.autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Seasons.winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            #endregion

            #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. 
            //Employee Employee = new Employee();
            //Employee.Name = "Ali";
            //Employee.Salary = 2000;
            //Employee.Age = 30;
            //Employee.Permissions = (Permissions)1;
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                        //XOR ^
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            //Console.WriteLine(Employee.Permissions);//Delete Execute Read
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                        //& AND
            //if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("permision already exsist");
            //}
            //else
            //{
            //    Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //    Console.WriteLine(Employee.Permissions);
            //}
            //// Or |
            ////use to check for permission
            //Employee.Permissions = Employee.Permissions | Permissions.Write;
            //Console.WriteLine(Employee.Permissions);
            #endregion

            #region 4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color name.");
            //}

            #endregion

            #region 5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //double x1 , y1 , x2 , y2 ;
            //bool x1Check, y1Check, x2Check, y2Check;
            //do
            //{
            //    Console.WriteLine("Enter the X of the first point:");
            //    x1Check = double.TryParse(Console.ReadLine(), out x1);
            //} while (!x1Check);

            //do
            //{
            //    Console.WriteLine("Enter the Y of the first point:");
            //    y1Check = double.TryParse(Console.ReadLine(), out y1);

            //} while (!y1Check);

            //do
            //{
            //    Console.WriteLine("Enter the X of the second point:");
            //    x2Check = double.TryParse(Console.ReadLine(), out x2);

            //} while (!x2Check);

            //do
            //{
            //    Console.WriteLine("Enter the Y of the second point:");
            //    y2Check = double.TryParse(Console.ReadLine(), out y2);

            //} while (!y2Check);

            //Point pointOne = new Point(x1,y1);
            //Point pointTwo = new Point(x2,y2);

            //var dis = Point.Calc(pointOne.X, pointOne.Y, pointTwo.X, pointTwo.Y);
            //Console.WriteLine($"The distance between the two points is {dis}");
            #endregion

            #endregion
            
        }
    }

}

