using System;

namespace отборочные
{
    public static class БиблиотекаМатеши
    {
        public static double Сумма(double chislo1, double chislo2) 
        {
            return chislo1 + chislo2;
        }
        public static double Разность(double chislo1, double chislo2)
        {
            return chislo1 - chislo2;
        }
        public static double Умножение(double chislo1, double chislo2)
        {
            return chislo1 * chislo2;
        }
        public static double Деление(double chislo1, double chislo2)
        {
            return chislo1 / chislo2;
        }
        public static double ПлощадьКруга(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public static double ПлощадьКвадрата(double P)
        {
            return P * 4;
        }
        public static double ПлощадьПараллелограмма(double a, double h )
        {
            return a * h;
        }
    }
}
