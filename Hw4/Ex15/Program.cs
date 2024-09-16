using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    /*
     * Создайте публичный класс Human в том же файле и namespace, что и класс Animal.
     * Для класса Animal объявите следующие переменные:
     *      1) name - отвечающую за имя.
     *      2) speed - отвечающую за скорость.
     *      3) age - отвечающую за возраст.
     *      4) owner - отвечающую за владельца.
     * Для класса Human объявите следующие переменные:
     *      1) name -  отвечающую за имя.
     *      2) age - отвечающую за возраст.
     * Все переменные классов должны быть публичными, тип и остальные модификаторы определите самостоятельно.
     * Для класса Animal объявите конструктор, который:
     *      1) Принимает имя, скорость, возраст и владельца животного, инициализируя соответствующие поля класса.
     *      2) Всегда присваивает значение имени с заглавной буквы.
     *      3) Присваивает значение "Кеша" имени экземпляра, если получена пустая строка с именем.
     *      4) Присваивает значение 7 возрасту экземпляра, если получено отрицательное или равное 0 значение с возрастом.
     *      5) Присваивает значение 121 скорости экземпляра, если получено отрицательное или равное 0 значение со скоростью.
     *      6) Присваивает новый экземпляр класса Human переменной owner с произвольным именем, если имя владельца "Аноним".
     * Возраст владельца при этом должен остаться без изменений.
     * Для класса Human объявите конструктор, который:
     *      1) Принимает имя и возраст, инициализируя соответствующие поля класса.
     *      2) Всегда присваивает значение имени с заглавной буквы.
     *      3) Присваивает значение "Аноним" имени экземпляра, если получена пустая строка с именем.
     */

   
    public class Animal
    {
        /* Добавьте свой код ниже */
        public string Name;
        public int Speed;
        public int Age;
        public Human Owner;

        public Animal(string name, int speed, int age, Human owner)
        {
            Name = 
            Speed = speed <= 0 ? 121 : speed;
            Age = age <= 0 ? 7 : age;
            Owner = owner.Name == "Аноним" ? new Human("", owner.Age) : owner;
        }


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Human owner = new Human("", 30);
            Animal animal = new Animal("", 0, 0, owner);

            Console.WriteLine($"Animal Name: {animal.Name}");
            Console.WriteLine($"Animal Speed: {animal.Speed}");
            Console.WriteLine($"Animal Age: {animal.Age}");
            Console.WriteLine($"Owner Name: {animal.Owner.Name}");
            Console.WriteLine($"Owner Age: {animal.Owner.Age}");
        }
    }

    /* Добавьте свой код ниже */
    public class Human
    {
        public string Name;
        public int Age;

        public Human(string name, int age)
        {
            Name =
            Age = age;
        }
    }
}
