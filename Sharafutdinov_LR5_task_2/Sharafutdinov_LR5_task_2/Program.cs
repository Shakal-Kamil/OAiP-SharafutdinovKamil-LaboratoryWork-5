using System;

namespace Vector3DApp
{
    class Program
    {
        static void Main()
        {
            Vector3D v1 = new Vector3D();
            Vector3D v2 = new Vector3D();

            Console.WriteLine("Первый вектор:");
            v1.Read();

            Console.WriteLine("\nВторой вектор:");
            v2.Read();

            Console.WriteLine("\n=== Результаты ===");
            Console.Write("Вектор 1: ");
            v1.Display();
            Console.Write("Вектор 2: ");
            v2.Display();

            Console.WriteLine($"\nДлина v1: {v1.Length():F2}");
            Console.WriteLine($"Длина v2: {v2.Length():F2}");

            Console.Write("\nСумма: ");
            v1.Add(v2).Display();

            Console.Write("Разность (v1 - v2): ");
            v1.Subtract(v2).Display();

            Console.WriteLine($"\nСкалярное произведение: {v1.DotProduct(v2):F2}");

            Console.Write("\nВведите скаляр для умножения: ");
            double s = double.Parse(Console.ReadLine());
            Console.Write($"v1 * {s}: ");
            v1.Multiply(s).Display();

            Console.WriteLine($"\nВекторы равны: {v1.IsEqual(v2)}");

            int cmp = v1.CompareLength(v2);
            Console.Write("Сравнение длин: ");
            if (cmp == 0) Console.WriteLine("равны");
            else if (cmp > 0) Console.WriteLine("v1 длиннее");
            else Console.WriteLine("v2 длиннее");
        }
    }
}