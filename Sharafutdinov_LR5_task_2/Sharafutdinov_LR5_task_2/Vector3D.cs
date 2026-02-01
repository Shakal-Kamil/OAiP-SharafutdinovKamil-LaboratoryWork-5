using System;

namespace Vector3DApp
{
    public class Vector3D
    {
        public double X, Y, Z;

        public void Read()
        {
            Console.Write("X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            Z = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"({X:F2}; {Y:F2}; {Z:F2})");
        }

        public Vector3D Add(Vector3D v)
        {
            return new Vector3D { X = X + v.X, Y = Y + v.Y, Z = Z + v.Z };
        }

        public Vector3D Subtract(Vector3D v)
        {
            return new Vector3D { X = X - v.X, Y = Y - v.Y, Z = Z - v.Z };
        }

        public double DotProduct(Vector3D v)
        {
            return X * v.X + Y * v.Y + Z * v.Z;
        }

        public Vector3D Multiply(double scalar)
        {
            return new Vector3D { X = X * scalar, Y = Y * scalar, Z = Z * scalar };
        }

        public bool IsEqual(Vector3D v)
        {
            return Math.Abs(X - v.X) < 0.001 &&
                   Math.Abs(Y - v.Y) < 0.001 &&
                   Math.Abs(Z - v.Z) < 0.001;
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public int CompareLength(Vector3D v)
        {
            double len1 = Length();
            double len2 = v.Length();

            if (Math.Abs(len1 - len2) < 0.001)
                return 0;
            return len1 > len2 ? 1 : -1;
        }
    }
}