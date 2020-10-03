using System;

namespace Module1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("операция(разность): ");
            double a = Module1.MatBiblioteka.Minus(8,3);
            Console.WriteLine(a);

            Console.Write("операция(сумма): ");
            double b = Module1.MatBiblioteka.Sum(4, 4);
            Console.WriteLine(b);

            Console.Write("операция(деление): ");
            double v = Module1.MatBiblioteka.Share(6,3);
            Console.WriteLine(v);

            Console.Write("операция(умножение): ");
            double c = Module1.MatBiblioteka.Multiply(5,5);
            Console.WriteLine(c);

            Console.Write("операция(Площадь круга): ");
            double s = Module1.MatBiblioteka.AreaCircle(4);
            Console.WriteLine(s);

            Console.Write("операция(Площадь квадрата): ");
            double x = Module1.MatBiblioteka.AreaSquare(4);
            Console.WriteLine(x);

            Console.Write("операция(Площадь Параллелограмма): ");
            double z = Module1.MatBiblioteka.AreaParallelogram(4,3);
            Console.WriteLine(z);
        }
    }
}
