using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t13
{
    /*
     * Создайте статический метод GetDistance(), который должен вычислять и возвращать расстояние между двумя точками на координатной плоскости.
     * Метод должен принимать X1 и Y1 - координаты первой точки, а также X2 и Y2 - координаты второй точки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            double x1 = 3.0;
            double y1 = 4.0;
            double x2 = 7.0;
            double y2 = 1.0;
            double distance = GetDistance(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {distance}");
        }

        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
