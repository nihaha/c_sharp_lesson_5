using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли 
 * клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. 
 * Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может 
 * двумя платежами по 300 и 400 грн. Закрыть весь долг. 
 * 
 * Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную 
 * экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма 
 * задолженности, сумма переплаты, сообщение об отсутствии долга).
 */
namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input total credit, UAH");
            double credit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input mandatory monthly payment, UAH");
            double mandatoryPayment = Convert.ToDouble(Console.ReadLine());

            double debt = credit;

            ShowInfo(credit, mandatoryPayment, ref debt);

            while (debt > 0)
            {
                Console.WriteLine("Input amount of your payment for this month, UAH");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (amount < mandatoryPayment)
                {
                    Console.WriteLine($"Input amount can not be less than mandatory payment {mandatoryPayment}, UAH");
                    continue;
                }

                ShowInfo(credit, mandatoryPayment, ref debt, amount);
            }

            if (debt < 0)
            {
                Console.WriteLine($"You've overpaid your creadit by {debt}, UAH");
            }
            Console.ReadLine();
        }

        static void ShowInfo(double credit, double mandatoryPayment, ref double debt, double amount = 0)
        {
            Console.WriteLine($"\nYour total credit: {credit}, UAH");
            Console.WriteLine($"Mandatory payment: {mandatoryPayment}, UAH");            
            if (amount != 0)
            {
                Console.WriteLine($"Your payment, {amount} UAH");
                debt -= amount;
            }
            Console.WriteLine($"Current debt: {debt}, UAH\n");
        }
    }
}
