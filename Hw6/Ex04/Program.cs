using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t4
{
    /*
     * В методе Main() удалите из динамического массива arrayList все повторяющиеся элементы, после чего 
     * отсортируйте массив в порядке возрастания и дополните его недостающими элементами так, чтобы получилось
     * непрерывно возрастающее на единицу множество от минимального до максимального элемента массива.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static ArrayList arrayList = new ArrayList() { 1, 5, 6, 7, 6, 8, 9, 10, 2, 5, 7, 9, 15 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            HashSet<int> nums = arrayList.Cast<int>().ToHashSet<int>();
            arrayList = new ArrayList(nums.ToList());
            arrayList.Sort();
            int length = arrayList.Count;
            int min = (int)arrayList[0];
            int max = (int)arrayList[length - 1];
            for (int i = min; i < max + 1; i++)
            {
                if (!arrayList.Contains(i))
                {
                    arrayList.Add(i);
                }
            }
            arrayList.Sort();
            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

