using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t14
{
    /*
     * Внутри метода Main() создайте словарь и заполните его 10 парами ключ-значение, введенными с клавиатуры.
     * Выведите на экран элементы словаря в следующем формате:
     * "key - value", где key и value соответствующие значения элемента словаря.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите ключ для элемента {i + 1}:");
                string key = Console.ReadLine();

                Console.WriteLine($"Введите значение для ключа '{key}':");
                string value = Console.ReadLine();
                dictionary[key] = value;
                
            }
            Console.WriteLine("Содержимое словаря:");
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}

