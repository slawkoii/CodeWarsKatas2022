using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas2022
{
    public class ListKatas
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> result = new List<int>();
            int minValue = numbers.Min();
            int maxValue = numbers.Max();
            for (int i = minValue; i <= maxValue; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();

            foreach (object v in listOfItems)
            {
                if (v is int)

                    result.Add((int)v);
            }
            return result;
        }

        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i <= list.Length - n; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    result[i].Add(list[i + j]);
                }                 
            }
            return result;
        }
    }
}
