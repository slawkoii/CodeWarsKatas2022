using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CodeWarsKatas2022
{
    internal class BaisicKatas
    {
        public static string SwitchItUp(int number)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>
            {
                {1,"One"}, {2,"Two"}, {3,"Three"}, {4, "Four"}, {5,"Five"}, {6,"Six"}, {7,"Seven"}, {8,"Eight"}, {9,"Nine"}, {0,"Zero"},
            };
            if (numbers.TryGetValue(number, out string result)) return result;
            else return "Not correct number entered";
        }

        public static int GetRealFloor(int n)
        {
            if (n > 12) return n - 2;
            if (n > 0) return n - 1;
            return n;
        }

        public static int ReverseNumber(int n)
        {
            int a = 1;
            if (n < 0) a = -1; n *= a;
            int result = 0;
            while (n > 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
            }

            return a * result;
        }

        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (BigInteger)System.Math.Pow(2, i);
            }

            return result;

        }
    }
}
