﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    /*
     * Реализуйте класс Cat, добавив ему целочисленное поле id.
     * Создайте для класса Cat конструктор, который принимает параметр id и выводит в консоль сообщение в формате:
     * "Привет привет котику с id: XXX", где ХХХ - id созданного экземпляра класса, переданный ему при вызове конструктора.
     * Создайте деструктор класса Cat и измените его таким образом, чтобы при обращении к нему на экран выводилась фраза:
     * "Пока пока котик с id: ХХХ", где ХХХ - id уничтожаемого экземпляра класса. 
     */

    public class Program
    {
        public static void CatAdd()
        {
            Cat cat1 = new Cat(1);
            Cat cat2 = new Cat(2);
        }
        public static void Main(string[] args)
        {
            CatAdd();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
    public class Cat
    {
        /* Добавьте свой код ниже */
        private int id;
        

        public Cat(int id)
        {
            this.id = id;
            Console.WriteLine($"Привет привет котику с id: {id}");
        }

        ~Cat()
        {
            Console.WriteLine($"Пока пока котик с id: {id}");
        }
    }
}