using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    /*
     * Реализуйте класс Dog таким образом, чтобы он мог инициализироваться при помощи следующих конструкторов:
     *      1) Имя.
     *      2) Имя, вес и возраст.
     *      3) Имя и возраст.
     *      4) Вес, цвет.
     *      5) Вес, цвет и адрес.
     * Защитите класс Dog от создания "бесполезных" экземпляров класса, определите обязательные значения и 
     * инициализируйте их произвольными значениями в каждом из созданных конструкторов.
     * Все элементы класса должны быть публичными.
     */

    public class Dog
    {
        /* Добавьте свой код ниже */
        public string Name;
        public double Weight;
        public int Age;
        public string Color;
        public string Address;
        public Dog(string name)
        {
            Name = name;
            Age = 1;
            Weight = 5;
            Color = "Brown";
            Address = "Unknown";
        }
        public Dog(string name, double weight, int age)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = "Brown";
            Address = "Unknown";
        }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
            Weight = 5;
            Color = "Brown";
            Address = "Unknown";
        }
        public Dog(double weight, string color)
        {
            Name = "Unknown";
            Age = 1;
            Weight = weight;
            Color = color;
            Address = "Unknown";
        }

        public Dog(double weight, string color, string address)
        {
            Name = "Unknown";
            Age = 1;
            Weight = weight;
            Color = color;
            Address = address;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Вес: {Weight} кг, Возраст: {Age} лет, Цвет: {Color}, Адрес: {Address}";
        }
        public static void Main(string[] args)
        {
        }
    }
}