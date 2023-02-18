using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу, в которой создайте метод, который принимает в качестве параметров три 
 * целочисленных значения и возвращает значение каждого аргумента, умноженного на 10. 
 * (Использовать out и ref)
 */
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;

            Multiply(ref x, ref y, ref z);

            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            Console.ReadLine(); 
        }

        static void Multiply(ref int x, ref int y, ref int z)
        {
            x *= 10;
            y *= 10;
            z *= 10;
        }

    }
}
