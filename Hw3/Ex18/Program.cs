using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    /*
     * Создайте статический метод GetMinimum(), который принимает четыре целых числа и возвращает наименьшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMinimum() в следующем формате:
     * "Самое маленькое число: ХХХ", где ХХХ - результат вызова метода GetMinimum().
     * Каждый из выводов результата работы метода GetMinimum() должен осуществляться с новой строки и с различными аргументами.
     * Если числа равны - выведите любое из них.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int r = GetMinimum(10,15,13,7);
            int g = GetMinimum(5,5,5,5);
            int h = GetMinimum(11,6,17,200);
            Console.WriteLine($"Самое маленькое число: {r}");
            Console.WriteLine($"Самое маленькое число: {g}");
            Console.WriteLine($"Самое маленькое число: {h}");
        }
        public static int GetMinimum(int a , int b, int c, int d)
        {
            if (a < b && a < c && a < d)
            {
                return a;
            }
            else if (c < a && c < b && c < d) 
            {
                return c;
            }
            else if (d < a && d < b && d < c)
            {
                return d;
            }
            else if (a == b && a == c && a == d)
            {
                return a;
            }
            else
            {
                return b;

            }
        }
    }
}
