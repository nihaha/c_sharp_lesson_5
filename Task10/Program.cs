using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое 
 * число и определяет количество разрядов данного числа. Пользователь должен иметь 
 * возможность вводит число с клавиатуры.
 */
namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int digits = 0;

            digits = NumberOfDigits(number, digits);

            Console.WriteLine($"Number of digits of number {number} is {digits}");
            Console.ReadLine();
        }

        static int NumberOfDigits(int number, int digits)
        {
            if (number != 0)
            {
                digits += 1;
                number /= 10;
                return NumberOfDigits(number, digits);
            }

            return digits;
        }
    }
}
