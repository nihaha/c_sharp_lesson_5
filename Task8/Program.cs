using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. N – число 
 * которое пользователь вводит с клавиатуры. (Использовать рекурсию)
 */
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            Recursion(number, counter);

            Console.ReadLine();
        }

        static void Recursion(int number, int counter)
        {           
            if (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;

                Recursion(number, counter);
            }            
        }
    }
}
