using System;

namespace UnitTestLesson
{
    public class Tasks
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public bool Boolean23(int value)
        {
            //Дано четырехзначное число. Проверить истинность высказывания:
            //«Данное число читается одинаково слева направо и справа налево».
            int a, b, c, d;
            int thevalue = value;
            a = value / 1000;
            value %= 1000;
            b = value / 100;
            value %= 100;
            c = value / 10;
            value %= 10;
            d = value;



            int nextvalue = d * 1000 + c * 100 + b * 10 + a;
            return thevalue == nextvalue;
        }
    }
}
