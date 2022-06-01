using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"The area of a circle with the radius of {r} is {area}");

        }
    }
}
