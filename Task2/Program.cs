using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу в которой создайте метод, который в качестве аргументов принимает 2 
 * числа и возвращает меньшее из них.
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second number:");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = leastNumber(x, y);

            Console.WriteLine($"Smallest number is: {result}");
            Console.ReadLine();
        }

        static double leastNumber(double x, double y)
        {
            return x < y ? x : y;
        }
    }
}
