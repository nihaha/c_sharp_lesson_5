using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу, которая будет вычислять сумму цифр числа N. Число N пользователь 
 * должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки, 
 * массивы (ну и циклы, разумеется). (Использовать рекурсию)
 */
namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum  = 0;

            sum = Recursion(number, sum);

            Console.WriteLine($"Sum of digits on number {number} equals to {sum}");
            Console.ReadLine();
        }

        static int Recursion(int number, int sum)
        {
            if (number != 0)
            {
                sum += number % 10;
                number /= 10;
                return Recursion(number, sum);
            }

            return sum + number;
        }
    }
}
