using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t15
{
    /*
     * Реализуйте метод MakeRandomList(), который принимает число N и возвращает список целых чисел, состоящий из N случайных чисел
     * от 1 до 100 включительно.
     * Реализуйте метод ConvertToSet(), который принимает список целых чисел, а возвращает множество элементов принятого списка без повторений.
     * Внутри метода Main() создайте и сохраните в отдельной переменной соответствующего типа результат работы метода MakeRandomList().
     * Внутри метода Main() создайте и сохраните в отдельной переменной соответствующего типа результат работы метода ConvertToSet(),
     * в качестве аргумента при вызове метода ConvertToSet() передайте первую сохранённую переменную.
     * Выведите в консоль информацию об изменении количества элементов в коллекциях в следующем формате:
     * "В изначальной коллекции было ХХХ элементов, а стало ХХХ элементов", где XXX значения соответствующих переменных метода Main().
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<int> randomList = MakeRandomList(17); 
            HashSet<int> uniqueSet = ConvertToSet(randomList);
            Console.WriteLine($"В изначальной коллекции было {randomList.Count} элементов, а стало {uniqueSet.Count} элементов");
        }

        public static List<int> MakeRandomList(int n)
        {
            /* Добавьте свой код ниже */
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                randomNumbers.Add(random.Next(1, 101)); 
            }
            return randomNumbers;
        }

        public static HashSet<int> ConvertToSet(List<int> list)
        {
            /* Добавьте свой код ниже */
            return new HashSet<int>(list);
        }
    }
}
