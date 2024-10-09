﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t18
{
    /*
     * Внутри метода Main() найдите все элементы массива arr, значения которых находятся +\-2 от среднего арифметического всех элементов массива.
     * Найденные значения поместите в отдельный массив и выведите все его элементы в консоль, каждый элемент с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = { 1.22, 1.7, 7.8, 2.4, 8, 2.3, 2.5, 2.6, 6, 17, 7, 8, 12, 1, 11, 12, 5, 7.2 };
            /* Добавьте свой код ниже */
       double average = arr.Average();

            double lowerBound = average - 2;
            double upperBound = average + 2;

            double[] resultArray = new double[arr.Length];
            int count = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= lowerBound && arr[i] <= upperBound)
                {
                    resultArray[count] = arr[i];
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
        }
    }
}
