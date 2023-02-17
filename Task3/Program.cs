using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте метод, который принимает в качестве аргумента год 
 * рождения пользователя и возвращает его полный возраст.
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input year of birth:");
            int year = Convert.ToInt32(Console.ReadLine());

            double age = GetAge(year);

            Console.WriteLine($"You are {age} years old");
            Console.ReadLine();
        }

        static int GetAge(int year)
        {
            return DateTime.Now.Year - year;
        }
    }
}
