using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35
{
    /*
     * Реализуйте перечисление MyFavoritePets, которое должно содержать как минимум 4 элемента, 
     * каждый из которых должен олицетворять названия ваших любимых домашних животных.
     * Реализуйте класс Animal, который должен содержать:
     *      1) Четыре поля класса: возраст, вес, скорость и тип.
     *      2) 1 конструктор, который принимает только тип животного.
     * Конструктор класса, должен инициализировать все недостающие поля класса, на основе переданного типа.
     * Все инициализированные в конструкторе поля класса должны иметь значения, отличные от значений по умолчанию.
     * Все элементы класса должны быть публичными.
     */
    public class Animal
    {
        /* Добавьте свой код ниже */
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public MyFavoritePets Type { get; set; }

        public Animal(MyFavoritePets type)
        {
            Type = type;
            switch (type)
            {
                case MyFavoritePets.Dog:
                    Age = 5; 
                    Weight = 20; 
                    Speed = 12; 
                    break;
                case MyFavoritePets.Cat:
                    Age = 3;
                    Weight = 4;
                    Speed = 15;
                    break;
                case MyFavoritePets.Panda:
                    Age = 2;
                    Weight = 60;
                    Speed = 4;
                    break;
                case MyFavoritePets.raccoon:
                    Age = 4;
                    Weight = 2;
                    Speed = 5;
                    break;
                default:
                    Age = 0;
                    Weight = 0;
                    Speed = 0;
                    break;
            }
        }

        public static void Main(string[] args)
        {
        }
    }

    public enum MyFavoritePets
    {
        /* Добавьте свой код ниже */
        Dog,
        Cat,
        Panda,
        raccoon
    }
}
