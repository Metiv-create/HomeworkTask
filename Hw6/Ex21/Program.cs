using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t21
{
    /*
     * Создайте класс Cat с публичным свойством Name. Переопределите для класса Cat метод ToString() так, чтобы он выводил фразу:
     * "Котик - ХХХ", где XXX - значение свойства Name.
     * Создайте для класса Cat конструктор, который принимает и устанавливает значение для свойства класса Cat.
     * Внутри метода Main() создайте словарь, ключ - число (порядковый номер созданного кота), значение - экземпляр класса Cat.
     * Создайте 10 экземпляров класса Cat и поместите их в словарь. Первый добавленный элемент словаря должен иметь значение ключа 1.
     * Выведите на экран все элементы словаря, каждый с новой строки, в следующем формате:
     * "В клетке №key сидит value", где key и value соответствующие значения элемента словаря.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<int, Cat> cats = new Dictionary<int, Cat>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите имя для кота №{i}: ");
                string name = Console.ReadLine();
                cats[i] = new Cat(name);
            }
            foreach (var kvp in cats)
            {
                Console.WriteLine($"В клетке №{kvp.Key} сидит {kvp.Value}");
            }
        }
        /* Добавьте свой код ниже */
        public class Cat
        {
            public string Name { get; set; }

            public Cat(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return $"Котик - {Name}";
            }
        }

    }
}
