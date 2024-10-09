using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t7
{
    /*
     * Создайте новую структуру Circle в том же файле и том же namespace, что и класс Program.
     * Структура должна содержать в себе следующие важные элементы:
     *      1) x,y - координаты центра окружности.
     *      2) r - радиус окружности.
     *      3) color - цвет линии окружности.
     * Создайте 3 конструктора для структуры Circle:
     *      1) Координаты центра окружности.
     *      2) Радиус.
     *      3) Цвет линии окружности
     * Если координаты центра окружности не заданы, то она должна находится в точке 2 2 координатной сетки.
     * Возможный шаг по координатной плоскости - целочисленный, радиус по умолчанию 1.
     * Дробный, отрицательный и нулевой радиус недопустимы. Цвет по умолчанию  - любой.
     * Все элементы структуры должны быть доступны за пределами самой структуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle(2, 2); 
            Circle circle2 = new Circle(5); 
            Circle circle3 = new Circle("red"); 

            Console.WriteLine($"X and Y ({circle1.X}, {circle1.Y}), R: {circle1.R}, Color: {circle1.Color}");
            Console.WriteLine($"X and Y ({circle2.X}, {circle2.Y}), R: {circle2.R}, Color: {circle2.Color}");
            Console.WriteLine($"X and Y ({circle3.X}, {circle3.Y}), R: {circle3.R}, Color: {circle3.Color}");
        }
    }

    /* Добавьте свой код ниже */
    struct Circle
    {
        public int X { get; }
        public int Y { get; }
        public int R { get; }
        public string Color { get; }
        public Circle(int x, int y)
        {
            X = x;
            Y = y;
            R = 1;
            Color = "purple";
        }
        public Circle(int r)
        {
            X = 2;
            Y = 2;
            R = (r > 0) ? r : 1 ;
            Color = "purple";
        }
        public Circle(string color)
        {
            X = 2;
            Y = 2;
            R = 1;
            Color = color;
        }
    }
}
