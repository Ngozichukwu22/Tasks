using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {   //Task1
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            
            
               
        }
        static void Task1()
        {
            int number;
            Console.Write("Enter any given number: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"This number {number} is an even number.");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine($"This number {number} is an odd number");
            }
        }
        //Task2
        static void Task2()
        {
            Console.Write("Please enter your number:");
            double n = double.Parse(Console.ReadLine());

            bool result = (n % 5 == 0) && (n % 7 == 0);
            Console.WriteLine($"Can this number {n} be divided by 5 and 7? ANSWER: {result}");
        }
        //Task3
        static void Task3()
        {
            Console.Write("please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int ThirdNum = (number / 100) % 10;
            if (ThirdNum == 7)
            {
                Console.WriteLine("The third number IS seven!");
            }
            else
            {
                Console.WriteLine("The third number IS NOT seven.");
            }

        }
        //Task4(I don't understand this solution shaa.)
        static void Task4()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);

        }

        //Task5
        static void Task5()
        {
            double a;
            double b;
            double h;
            double Area;

            Console.Write("Enter the value of A-Base: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of B-Base: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of Height: ");
            h = int.Parse(Console.ReadLine());


            Area = (a + b) / (2 * h);
            Console.WriteLine($"The Area of a Trapezoid is {Area} ");

        }
        //Task6
        static void Task6()
        {
            double l;
            double b;
            double Area;
            double Perimeter;

            Console.Write("Enter the length of the Rectangle: ");
            l = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of the Rectangle: ");
            b = double.Parse(Console.ReadLine());

            Area = (l * b);
            Perimeter = 2 * (l + b);

            Console.WriteLine($"The Area of the triangle is {Area} sq. units");

            Console.WriteLine($"The Perimeter of the triangle is {Perimeter} units");

        }
        //Task7
        static void Task7()
        {
            double Moonweight;
            double Earthweight;

            Console.Write("Enter the weight of the man: ");
            Earthweight = double.Parse(Console.ReadLine());

            Moonweight = (Earthweight * 0.17);
            Console.WriteLine($"The weight of a man on the Moon,\n" +
                $" whose weight on Earth was {Earthweight}Kg is {Moonweight}Kg"); ;
        }
        //Task8
        static void Task8()
        {
            int x;
            int y;
            Console.Write("Enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            y = int.Parse(Console.ReadLine());
            bool isInside = (x * x + y * y ) <= 5 ? true : false;
            Console.WriteLine($"The point O({x},{y}) is inside K((0,0),5)?: {isInside}");
        }
        //Task9
        static void Task9()
        {

            {
                int x;
                int y;
                Console.Write("Enter x: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter y: ");
                y = Convert.ToInt32(Console.ReadLine());
                bool isInsideCircle = (x * x + y * y <= 5) ? true : false;
                bool isOutsideRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
                Console.WriteLine($"The point O({x},{y}) is inside K((0,0),5)?: {isInsideCircle}");
                Console.WriteLine($"The point O({x},{y}) is outside rectangle " +
                    $"((-1, 1), (5, 5)?: {isOutsideRectangle}");
            }
        }
        //Task10
        static void Task10()
        {                       
                int number;
                int a;
                int b;
                int c;
                int d;


                Console.Write("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());
                a = number / 1000;
                b = (number / 100) % 10;
                c = (number / 10) % 10;
                d = number % 10;

                Console.WriteLine("Sum of digits = {0}",a + b + c + d);
                Console.WriteLine($"Digits printed backwards = {d}{c}{b}{a}");
                Console.WriteLine($"Last digit on first place = {d}{a}{b}{c}");
                Console.WriteLine($"Exchange third and second digits = {a}{c}{b}{d}");
            }


    }
}
