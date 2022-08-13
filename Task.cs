using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task
    {
        static Task()
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

            Console.WriteLine($"Sum of digits = {number}", a + b + c + d);
            Console.WriteLine($"Digits printed backwards = {d}{c}{b}{a}");
            Console.WriteLine($"Last digit on first place = {d}{a}{b}{c}");
            Console.WriteLine($"Exchange third and second digits = {a}{c}{b}{d}");
        }
    }
}
    
        
