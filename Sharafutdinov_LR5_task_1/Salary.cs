using System;

namespace SalaryCalculator
{
    public class Salary
    {
        public double first;  
        public int second;    

        public void Read()
        {
            Console.Write("Введите оклад: ");
            first = double.Parse(Console.ReadLine());

            Console.Write("Введите количество отработанных дней: ");
            second = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"\nОклад: {first:F2}");
            Console.WriteLine($"Отработано дней: {second}");
            Console.WriteLine($"Начисленная зарплата: {Summa():F2}");
        }

        public double Summa()
        {
            const int workDaysInMonth = 22;
            return first / workDaysInMonth * second;
        }
    }
}