using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    /*
     * Создайте статический метод GetMinimum() который принимает два целых числа и возвращает наименьшее из них.
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
            int r = GetMinimum(10,15);
            int g = GetMinimum(5,5);
            int h = GetMinimum(11,6);
            Console.WriteLine($"Самое маленькое число: {r}");
            Console.WriteLine($"Самое маленькое число: {g}");
            Console.WriteLine($"Самое маленькое число: {h}");
        }
        public static int GetMinimum(int a , int b)
        {
            if (a < b)
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
