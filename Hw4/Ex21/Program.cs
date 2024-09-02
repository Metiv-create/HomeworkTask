﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    /*
     * Реализуйте класс Human таким образом, чтобы он содержал 3 свойства:
     *      1) Имя.
     *      2) Профессия.
     *      3) Возраст.
     * Добавьте в класс Human конструктор, который принимает имя, а устанавливает и имя, и возраст, и профессию.
     * Сделайте так, чтобы профессию и возраст нельзя было изменить.
     * Переопределите метод ToString() для класса Human, так чтобы на экран выводилась информация об
     * экземпляре класса в следующем формате:
     * "Имя: ХХХ"
     * "Возраст: ХХХ"
     * "Профессия: ХХХ"
     * ХХХ - значения соответствующих полей экземпляров класса Human.
     */

    public class Human
    {
        /* Добавьте свой код ниже */
        public string Name { get; private set; }
        public string Profession { get; private set; }
        public int Age { get; private set; }
        public Human(string name)
        {
            Name = name;
            Age = 0; 
            Profession = "студент"; 
        }
        public override string ToString()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nПрофессия: {Profession}";
        }
        public void SetProfessionAndAge(string profession, int age)
        {
            if (Profession == "студент")
            {
                Profession = profession;
            }
            if (Age == 0) 
            {
                Age = age;
            }
        }

        public static void Main(string[] args)
        {
            Human human = new Human("Егор");
            human.SetProfessionAndAge("програмист", 0);
            Console.WriteLine(human.ToString());
        }
        /* Добавьте свой код ниже */
    }
}
