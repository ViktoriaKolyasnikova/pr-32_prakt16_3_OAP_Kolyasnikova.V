using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt16_3_OAP_Kolyasnikova.V
{
    class V
    {
        public V(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double X;
        public double Y;
        public double Z;
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static V operator +(V l, V r)
        {
            return new V(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
        public static V operator -(V l, V r)
        {
            return new V(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }
        public static double operator *(V l, V r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }
        public static double Cos(V l, V r)
        {
            return (l * r) / (l.GetLength() * r.GetLength());
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            V v1 = new V(10, 20, 30);
            V v2 = new V(40, 50, 60);
            V v3 = v1 + v2;
            V v4 = v1 - v2;
            double z = v2 * v3;
            double s = V.Cos(v1, v2);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
