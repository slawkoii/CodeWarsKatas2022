using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas2022
{
    public class ArrayKatas
    {
        public static int Min(int[] list) => list.Min();
        public static int Max(int[] list) => list.Max();

        public static void ShowAnArray(object[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }

        public static bool SmallEnough(int[] a, int limit)
        {
            bool answer = true;
            for (int i = 0; i <= a.Length; i++)
            {
                if (a[i] > limit) answer = false;
            }
            return answer;
        }

        public static string[] AddLength(string str)
        {
            string[] arr = str.Split(" ");
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i] + " " + arr[i].Length);
            }
            return result.ToArray();
        }

        public static object[] TakeFirstElements(object[] array, int n = 1)
        {

            object[] result;

            if (n > array.Length) n = array.Length;

            if (n <= 0) result = new object[] { };

            else result = new object[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = array[i];
            }

            return result;
        }
    }
}
