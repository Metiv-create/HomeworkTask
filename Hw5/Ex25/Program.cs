using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t25
{
    /*
     * Реализуйте метод LookMomNoHands(), который должен возвращать массив, в котором все элементы столбцов принятого массива 
     * отсортированы в порядке возрастания элементов. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] { 1, 2, 1, 0, 7 };
            arr[1] = new int[] { 2, 4, 1, 5, 7 };
            arr[2] = new int[] { 3, 1, 7, 3, 2 };
            arr[3] = new int[] { 0, 3, 8, 1, 1 };
            arr[4] = new int[] { 4, 5, 3, 0, 2 };
            arr = LookMomNoHands(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] LookMomNoHands(int[][] arr)
        {
            /* Добавьте свой код ниже */
            int rowCount = arr.Length;
            int colCount = arr[0].Length;
            int[][] sortedArr = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                sortedArr[i] = new int[colCount];
            }
            for (int col = 0; col < colCount; col++)
            {
                int[] columnElements = new int[rowCount];
                for (int row = 0; row < rowCount; row++)
                {
                    columnElements[row] = arr[row][col];
                }
                Array.Sort(columnElements);
                for (int row = 0; row < rowCount; row++)
                {
                    sortedArr[row][col] = columnElements[row];
                }
            }
            return sortedArr;
        }
    }
}
