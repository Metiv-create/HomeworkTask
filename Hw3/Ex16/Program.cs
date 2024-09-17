using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    /*
     *  Создайте статический метод GetMaximum() который принимает два целых числа и возвращает наибольшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMaximum() в следующем формате:
     * "Самое большое число: ХХХ", где ХХХ - результат вызова метода GetMaximum().
     * Каждый из выводов результата вызова метода GetMaximum() должен осуществляться с новой строки и с различными аргументами.
     * Если числа равны - выведите любое из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int r = GetMaximum(10,15);
            int g = GetMaximum(5,5);
            int h = GetMaximum(11,6);
            Console.WriteLine($"Самое большое число: {r}");
            Console.WriteLine($"Самое большое число: {g}");
            Console.WriteLine($"Самое большое число: {h}");
        }
        public static int GetMaximum(int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a == b)
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
