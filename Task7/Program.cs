using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Написать программу, в которой создайте один метод, который будет вычислять площадь и периметр прямоугольника. 
 * Сторони прямоугольника пользователь должен иметь возможность вводит с клавиатуры.
 */
namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first side length:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second side length:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Calculate(sideA, sideB, out double square, out double perimeter);

            Console.WriteLine($"Square equals to {square}, m2");
            Console.WriteLine($"Perimetr equals to {perimeter}, m");
            Console.ReadLine();
        }

        static void Calculate(double sideA, double sideB, out double square, out double perimeter)
        {
            square = sideA * sideB;
            perimeter = (sideA + sideB) * 2;
        }
    }
}
