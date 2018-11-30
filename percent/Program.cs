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
        static void Main(string[] args)
        {
            string[] headerDeposit = { "сумма вклада", "проценты по вкладу", "срок вклада в месяцах" };
            double[] depositData = { 0, 0, 0 };

            Console.WriteLine("Введите данные по вкладу: \n");
            GetValueDeposit(headerDeposit, depositData);

            Console.WriteLine($"\nСумма к выдаче: {Calculate(depositData)}\n");
        }

        public static void GetValueDeposit(string[] header, double[] value)
        {
            for (int i = 0; i < header.Length; i++)
            {
                Console.WriteLine(header[i]);
                value[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        public static double Calculate(double[] depositData)
        {
            double sumDeposit = depositData[0] * Math.Pow((1 + (depositData[1] / 100) * (1 / 12.0)), depositData[2]);
            return sumDeposit;
        }
    }
}
