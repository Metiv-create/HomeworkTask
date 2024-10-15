using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t6
{
    /*
     * Реализуйте класс Cat, он должен:
     *      1) Содержать свойство Id.
     *      2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
     *      3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
     * Внутри метода Main() создайте коллекцию экземпляров класса Cat. Создайте 100 экземпляров класса Cat, а
     * в созданную коллекцию добавьте только котов с четными значениями id.
     * Выведите на экран содержимое коллекции, каждое значение с новой строки. Циклом foreach пользоваться нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<Cat> cats = new List<Cat>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) 
                {
                    cats.Add(new Cat(i));
                }
            }
            for (int i = 0; i < cats.Count; i++)
            {
                Console.WriteLine(cats[i].ToString());
            }
        }

    }

    public class Cat
    {
        /* Добавьте свой код ниже */
        int Id;
        public Cat(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"Я котик и мой id = {Id}";
        }
    }
}

