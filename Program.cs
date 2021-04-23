using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, press Enter");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter decimal number, press Enter");
            float b = Convert.ToSingle(Console.ReadLine()); ;
            
            Console.WriteLine("");

            Console.WriteLine($"Numbers {a} un {b} summa ir {a + b}");
            Console.WriteLine($"SNumbers {a} un {b} differnence = {a - b}");
            Console.WriteLine($"Numbers {a} un {b} division {a / b}");
            Console.WriteLine($"Numbers {a} un {b} multiplication {a * b}");
            Console.WriteLine($"Numbers {a} un {b} sum squared {(a + b) * (a + b)}");
            Console.WriteLine("");
            Console.WriteLine($"Cosinuss of numbers {a} & {b} sum = {Math.Cos(a + b)}");
            Console.WriteLine($"Sinuss of numbers {a} & {b} sum = {Math.Sin(a + b)}");
            Console.WriteLine($"Tangens no skaitļu {a} & {b} sum = {Math.Tan(a + b)}");
            Console.WriteLine($"Logaritms of numbers {a} & {b} sum = {Math.Log(a + b)}");
            Console.WriteLine($"square root of {a} & {b} sum of {Math.Sqrt(a + b)}");
            Console.WriteLine("");







        }
    }
}
