using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    /*
     * Для класса Dog добавьте следующие переменные:
     *      1) name - отвечающую за имя.
     *      2) speed - отвечающую за скорость.
     *      3) age  - отвечающую за возраст.
     *      4) weight - отвечающую за вес.
     *      5) dogCount - отвечающую за общее количество созданных экземпляров класса Dog.
     * Все переменные сделайте публичными, тип и остальные модификаторы определите самостоятельно.
     * Для класса Dog измените конструктор по умолчанию таким образом, чтобы он:
     *      1) Увеличивал общее количество созданных экземпляров.
     *      2) Присваивал значение равное 1 всем целочисленным переменным класса Dog, относящимся к экземпляру класса.
     */

    public class Dog
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        private static int dogCount = 0;
        public static int DogCount
        {
            get { return dogCount; }
        }
        public Dog()
        {
            dogCount++;
            Speed = 1;
            Age = 1;
            Weight = 1;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Скорость: {Speed} м/с, Возраст: {Age} лет, Вес: {Weight} кг.";
        }
        public static void Main(string[] args)
        {
            Dog dog1 = new Dog { Name = "Бобик", Speed = 10, Age = 3, Weight = 15 };
            Dog dog2 = new Dog();


            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine($"Общее количество созданных собак: {Dog.DogCount}");
        }
    }
}
