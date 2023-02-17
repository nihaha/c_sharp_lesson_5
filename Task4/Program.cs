using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Напишите программу консольный калькулятор. В данной программе должны быть четыре 
 * метода, метод для сложения, вычитания, умножения и деления. Каждый из методов должен 
 * принимать 2 целочисленных аргумента и выполнять соответствующею действие. Метод для 
 * деления должен выполнять проверку деления на ноль. Также необходимо предоставить 
 * пользователю возможность вводить знак арифметической операции, в зависимости от знака 
 * вызывать соответствующий метод. Также пользователю необходимо предоставить возможность 
 * вводит значения аргументов.
 */
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second number:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input operation sign:");
            string sign = Console.ReadLine();

            double result = 0;

            switch (sign)
            {
                case "+":
                    result = Add(x, y);
                    break;
                case "-":
                    result = Subtract(x, y);
                    break;
                case "*":
                    result = Multiply(x, y);
                    break;
                case "/":
                    result = Divide(x, y);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Result is: {result}");
            Console.ReadLine();
        }

        static double Add(double x, double y) { return x + y; }
        static double Subtract(double x, double y) { return x - y; }
        static double Multiply(double x, double y) { return x * y; }
        static double Divide(double x, double y) 
        { 
            if (y == 0)
            {
                Console.WriteLine($"You can not divide by 0!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            return x / y;
        }
    }
}
