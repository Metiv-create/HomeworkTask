﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t9
{
    /*
     * Внутри метода Main() создайте новую переменную и присвойте ей словарь, со строковым типом ключа и значения.
     * Добавьте в словарь 5 ваших любимых игрушек из детства и дайте их краткое описание. Выведите на экран
     * содержимое словаря в следующем формате:
     * "Мою игрушку зовут KEY и это: VALUE", где KEY и VALUE это соответствующие элементы словаря.
     * Метод Main() не должен ничего считывать с клавиатуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> toys = new Dictionary<string, string>
            {
                { "Конструктор Лего", "Набор пластиковых блоков" },
                { "Плюшевый медведь", "Мягкая игрушка в виде медведя" },
                { "Пистолет нёрф", "пив паф))" },
                { "Автомобиль на радиоуправлении", "Машинка, которую можно управлять с помощью пульта" },
                { "Настольная игра", "Игра, в которую можно играть с друзьями " }
            };

            // Выводим содержимое словаря в заданном формате
            foreach (var toy in toys)
            {
                Console.WriteLine($"Мою игрушку зовут {toy.Key} и это: {toy.Value}");
            }
        }
    }
}
