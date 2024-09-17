using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    /*
     * Реализуйте класс Rectangle, который содержит четыре целочисленные переменные - координаты Х вершин прямоугольника.
     * Создайте 5 конструкторов для класса Rectangle.
     */
    public class Rectangle
    {
        /* Добавьте свой код ниже */
        int a;
        int b;
        int c;
        int d;

        public Rectangle()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
        }
        public Rectangle(int a)
        {
            this.a = 1;
        }
        public Rectangle(int a,int b)
        {

        }
        public Rectangle(int a,int b,int c)
        {

        }
        public Rectangle(int a,int b,int c,int d)
        {

        }
        public static void Main(string[] args)
        {
        }
    }
}
