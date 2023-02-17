using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу в которой создайте метод, который принимает в качестве параметров три 
 * целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.
 */
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second number:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input third number:");
            double z = Convert.ToDouble(Console.ReadLine());

            double result = average(x, y, z);

            Console.WriteLine($"Average: {result}");
            Console.ReadLine();
        }

        static double average(double x, double y, double z)
        {
            return (x + y + z) / 3; 
        }
    }
}
