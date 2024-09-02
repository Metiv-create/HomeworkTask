using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Для всех приватных полей класса Flower реализуйте сеттеры и геттеры.
     * Шаблон полей класса изменять нельзя.
     */

    public class Flower
    {
        private string color = "NoColor";
        private string title = "NoTitle";

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Flower flower = new Flower();

            flower.SetColor("Красный");
            flower.SetTitle("Роза");

            flower.GetColor();
            flower.GetTitle();
        }

        public void GetColor()
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Цвет: " + color);
        }
        public void SetColor(string newColor)
        {
            /* Добавьте свой код ниже */
            color = newColor;
        }
        public void GetTitle()
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Название: " + title);
        }
        public void SetTitle(string newTitle)
        {
            /* Добавьте свой код ниже */
            title = newTitle;
        }
    }
}
