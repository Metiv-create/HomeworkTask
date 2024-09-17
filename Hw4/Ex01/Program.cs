using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    /*
     * Внутри метода Main() создайте программу, которая считывает 5 чисел с клавиатуры
     * и выводит в консоль наименьшее из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            {
                int[] numbers = new int[5];
                int min = int.MaxValue;

                Console.WriteLine("Введите 5 чисел:");
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());

                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                Console.WriteLine($"Наименьшее число: {min}");
            }
        }
    }
}
