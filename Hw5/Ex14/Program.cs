using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t14
{
    /*
     * Внутри метода Main() создайте массив из 10 целых чисел и сохраните его в соответствующую переменную.
     * Считайте с клавиатуры 10 чисел и добавьте их в массив. Отсортируйте полученный массив в порядке возрастания
     * и выведите его на экран, каждый элемент массива с новой строки. Методом Sort пользоваться нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int[] numbers = new int[10];

            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(ref numbers);
            string nums = string.Join(" ", numbers);
            Console.WriteLine(nums);
        }
        private static void BubbleSort(ref int[] array)
        {
            for (int j = array.Length-1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}
