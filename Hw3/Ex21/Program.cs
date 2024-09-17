using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Считайте с клавиатуры 4 целых числа.
     *      2) Выведите в консоль фразу "Количество отрицательных чисел: ХХХ, количество положительных чисел: ХХХ".
     * ХХХ - количество положительных и отрицательных чисел.
     * Число 0 - не положительное и не отрицательное, его при подсчете учитывать не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int positiveNum = 0;
            int negativeNum = 0;
            
            for (int i = 0; i < 4; i++)
            {
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                negativeNum++;
            }
            else if ( num > 0)
            {
                positiveNum++;
            }
            }
            Console.WriteLine("положительных чисел:"+ positiveNum);
            Console.WriteLine("отрицательных чисел:"+ negativeNum);
        }
    }
}
