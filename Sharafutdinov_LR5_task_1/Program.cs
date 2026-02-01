using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Расчет начисленной зарплаты");

            Salary salaryCalculator = new Salary();

            salaryCalculator.Read();

            salaryCalculator.Display();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}