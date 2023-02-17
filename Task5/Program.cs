using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу для конвертирования валюты. Пользователь должен иметь возможность 
 * ввести курс валюты, в которую он хочет конвертировать, сумму которую он хочет 
 * конвертировать. Программа должна вывести сумму денег в соответствующей валюте.
 */
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input convertion rate:");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input amount of money, UAH:");
            double money = Convert.ToDouble(Console.ReadLine());

            double result = Convertion(rate, money);

            Console.WriteLine($"You will get USD {result}");
            Console.ReadLine();
        }

        static double Convertion(double rate, double amount) 
        {
            return Math.Round(amount / rate, 2);
        }
    }
}
