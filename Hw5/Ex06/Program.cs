using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t6
{
    /*
     * Реализуйте метод MakeIntArray(), который должен возвращать массив из N чисел, заполненный
     * случайными целыми числами от 1 до 100 включительно.
     * Реализуйте метод MakeCustomIntArray(), который должен:
     *      1) Принимать в себя массив целых чисел и параметр А.
     *      2) Выводить на экран все элементы полученного массива, которые меньше или равны параметру А. Каждый элемент с новой строки.
     *      3) Иметь исходящий параметр, с количеством элементов, удовлетворяющих данному условию.
     * Внутри метода Main() вызовите метод MakeCustomIntArray(), передав ему в качестве аргументов произвольное число и
     * результат вызова метода MakeIntArray(). Присвойте переменной r исходящий параметр метода MakeCustomIntArray().
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int N = 10; 
            int A = 100;
            int[] randomArray = MakeIntArray(N);
            MakeCustomIntArray(randomArray, A, out int r);
            Console.WriteLine($"Количество элементов {A}: {r}");
        }
        public static int[] MakeIntArray(int N)
        {
            Random random = new Random();
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            return array;
        }

        public static void MakeCustomIntArray(int[] array, int A, out int count)
        {
            count = 0; 

            foreach (var number in array)
            {
                if (number <= A)
                {
                    Console.WriteLine(number); 
                    count++; 
                }
            }
        }
    }
}
