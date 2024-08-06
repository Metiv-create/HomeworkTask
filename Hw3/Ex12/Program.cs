﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    /*
     * Создайте статический метод IsTriangleExist(), который принимает в себя 3 целых числа - длины сторон треугольника.
     * В случае, если треугольник с переданными сторонами существует, метод должен вернуть true.
     * В случае, если треугольник с переданными сторонами не существует, метод должен вернуть false.
     * Внутри метода Main() выведите в консоль результат вызова метода IsTriangleExist() со следующими аргументами:
     *     1) 10, 2, 3.
     *     2) 1, 2, 3.
     *     3) 3,4,5.
     * ===================================================================================================================
     *   Треугольник существует только тогда, когда сумма любых двух его сторон больше третьей. Требуется сравнить каждую 
     *   сторону с суммой двух других. Если хотя бы в одном случае сторона окажется больше или равна сумме двух других,
     *   то треугольника с такими сторонами не существует.
     * ===================================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            IsTriangleExist(10,2,3);
            IsTriangleExist(1,2,3);
            IsTriangleExist(3,4,5);
        }

        /* Добавьте свой код ниже */
        public static void IsTriangleExist(int a,int b ,int c)
        {
            bool sumsOfSide1 = a + b > c;
            bool sumsOfSide2 = a + c > b;
            bool sumsOfSide3 = b + c > a;
            if (sumsOfSide1 && sumsOfSide2 && sumsOfSide3)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
    }
}
