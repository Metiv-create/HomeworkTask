using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    /*
     * Для класса SpaceDog создайте следующие свойства:
     *      1) Name.
     *      2) Age.
     *      3) inSpace.
     *      4) goingToSleep.
     *      5) IsAtHome.
     * Для класса SpaceDog создайте конструктор, который принимает: имя, возраст и статус бодрствования.
     * Свойства inSpace и IsAtHome реализуйте таким образом, чтобы они всегда имели противоположные
     * значения.
     * Переопределите метод ToString() для класса SpaceDog, чтобы он выводил информацию об экземпляре в следующем формате:
     * "Меня зовут ХХХ, я первый космонавт! Мне ХХХ лет, я нахожусь дома\в космосе. Я скоро пойду спать\Я недавно проснулся!"
     * Итоговая строка должна зависеть от значений соответствующих свойств экземпляра класса SpaceDog.
     */

    public class SpaceDog
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public int Age { get; set; }
        public bool inSpace { get; set; }
        public bool goingToSleep { get; set; }
        
        public bool IsAtHome
        {
            get { return !inSpace; }
        }

        public SpaceDog(string name, int age, bool isAwake)
        {
            Name = name;
            Age = age;
            inSpace = !isAwake;
            goingToSleep = !isAwake;
        }

        public override string ToString()
        {
            string location = inSpace ? "в космосе" : "дома";
            string sleepStatus = goingToSleep ? "Я скоро пойду спать" : "Я недавно проснулся!";
            
            return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь {location}. {sleepStatus}";
        }

        public static void Main(string[] args)
        {
            SpaceDog dog = new SpaceDog("Котяра", 5, true);
            Console.WriteLine(dog.ToString());
        }

        /* Добавьте свой код ниже */
    }
}
