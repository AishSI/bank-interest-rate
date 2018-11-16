using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            String[] depositData = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double initialAmount = double.Parse(depositData[0], CultureInfo.InvariantCulture); // исходная сумма
            double interestRate = double.Parse(depositData[1], CultureInfo.InvariantCulture); //процентная ставка
            double timeDepositMonth = double.Parse(depositData[2], CultureInfo.InvariantCulture); // срок вклада в месяцах

            double sumDeposit = initialAmount * Math.Pow((1 + (interestRate / 100) * (1 / 12.0)), timeDepositMonth);

            return sumDeposit;

        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Сумма к выдаче: {Calculate(Console.ReadLine())}");
        }
    }
}