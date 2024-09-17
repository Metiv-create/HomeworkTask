using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34
{
    /*
     * Внутри класса Program создайте и реализуйте публичный метод GetMoreInformation(), который:
     *      1) Принимает 1 целочисленный параметр.
     *      2) Выводит в консоль информацию о полученном числе в следующем формате:
     *         "Число ХХХ отрицательное\положительное! Число состоит из N цифр!",
     *         где ХХХ - значение полученного параметра, N - количество цифр в полученном числе.
     *      3) Если введённое число ноль - метод ничего не должен выводить в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            GetMoreInformation(10);
            GetMoreInformation(256);
            GetMoreInformation(0);
            GetMoreInformation(-57);
        }
        public static void GetMoreInformation(int a)
        {
            string b = a.ToString();
            int digitCount = b.Length;
            if (a < 0)
            {
                digitCount--;
                Console.WriteLine($"Число {a} отрицательное! Число состоит из {digitCount} цифр!");
            }
            else if (a > 0)
            {
                Console.WriteLine($"Число {a} положительное! Число состоит из {digitCount} цифр!");
            }
        }
    }
}


