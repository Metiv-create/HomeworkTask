using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t13
{
    /*
     * Реализуйте метод MyOwnSortMethod(), который должен принимать список целых чисел, а возвращать
     * их в виде списка целых чисел, отсортированного в порядке убывания. Методом Sort пользоваться нельзя.
     * Шаблон задачи изменять нельзя.  
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> originalList = new List<int>() { 12, 23, 123, 123, 545, 23, 12, 434567, 79, 89, 678, 56, 345, 233, 1290, 78, 567, 345, 12, 23, 577658, 987 };
            List<int> sortedList = MyOwnSortMethod(originalList);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> MyOwnSortMethod(List<int> p)
        {
            /* Добавьте свой код ниже */
            List<int> sortedList = new List<int>(p);
            int n = sortedList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedList[j] < sortedList[j + 1])
                    {
                        int temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }
            return sortedList;
        }
    }
}

