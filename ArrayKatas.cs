using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }

        public static int Grow(int[] x)
        {
            int result = 1;
            for (int i = 0; i < x.Length; i++)
                result *= x[i];
            return result;
        }

        public static long RowSumOddNumbers(long n) => (long)Math.Pow(n, 3);

        public static bool HasSurvived(int[] attackers, int[] defenders)
        {                       
            int asurvie = 0;
            int dsurvie = 0;

            if (attackers.Length > defenders.Length)
                Array.Resize(ref defenders, attackers.Length);
            else
                Array.Resize(ref attackers, defenders.Length);                     
          
             for(int i= 0; i < attackers.Length; i++)
                {
                    if (attackers[i] > defenders[i] )  asurvie++; 
                    else dsurvie++;                        
                }          
            
            if(asurvie > dsurvie) { return false; }
            if(attackers.Sum()<=defenders.Sum()){ return true; }
            else return false;
            
        }

        public static double FindAverage(double[] array) => (array.Length == 0) ? 0 : array.Average();       

       
    }
}
