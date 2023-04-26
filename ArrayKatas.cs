namespace CodeWarsKatas2022
{
    public class ArrayKatas
    {
        public static int Min(int[] list) => list.Min();
        public static int Max(int[] list) => list.Max();

        public static void ShowAnArray(string[] table)
        {
            foreach (var item in table)
            {
                Console.WriteLine(item);
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

            for (int i = 0; i < attackers.Length; i++)
            {
                if (attackers[i] > defenders[i]) asurvie++;
                else dsurvie++;
            }

            if (asurvie > dsurvie) { return false; }
            if (attackers.Sum() <= defenders.Sum()) { return true; }
            else return false;

        }

        public static double FindAverage(double[] array) => (array.Length == 0) ? 0 : array.Average();

        public static long[] Digitize(long n)
        {
            int length = n.ToString().Length;
            long[] result = new long[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = n % 10;
                n /= 10;
            }
            return result;
        }

        public static long[] Digitize2(long n) =>
             n.ToString().ToCharArray().Reverse().Select(x => Convert.ToInt64(x.ToString())).ToArray();

        public static bool None(int[] arr, Func<int, bool> fun)
        {

            foreach (var i in arr)
            {
                if (fun(i)) return false;
            }
            return true;
        }

        public static string MultiTable(int number)
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result = result + i.ToString() + " * " + number.ToString() + " = " + (number * (i)).ToString() + "\n";
            }
            return result.Substring(0, result.Length - 1);
        }

        public static string Well(string[] x)
        {
            int goodIdeas = 0;
            string response = "I smell a series!";
            foreach (string v in x)
            {
                if (v == "good") goodIdeas++;
            }
            switch (goodIdeas)
            {
                case 0: return "Fail!";
                case 1: return "Publish!";
                case 2: return "Publish!";
                default:
                    break;

            }
            return response;

        }

        public static long StairsIn20(int[][] stairs)
        {
            long result = 0;
            foreach (var stair in stairs)
            {
                result += stair.Sum();
            }

            return result * 20;
        }

        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            if (scores[0] == scores[1]) return $"At match {teams[0]} - {teams[1]}, teams played draw.";
            if (scores[0] > scores[1]) return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
            else return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
        }

        public static bool LogicalCalc(bool[] array, string op)
        {
            if (op == "AND")
                return array.All(x => x);
            else if (op == "OR")
                return array.Any(x => x);
            else
                return array.Aggregate((i, j) => i ^ j);
        }

        public static bool All(int[] arr, Func<int, bool> fun) => arr.All(fun);

        public static string ArrayToChange(string s) =>
            s.Split(',').Length < 3 ? null : string.Join(" ", s.Split(',')[1..^1]);


        public static string FindNeedle(object[] haystack) =>
            $"found the needle at position {Array.IndexOf(haystack, "needle")}";

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            result.AddRange(arr1);
            result.AddRange(arr2);
            result.Sort();
            return result.Distinct().ToArray();
        }

        public static string TempleStrings(string obj, string feature) =>
            obj + " are " + feature;


    }
}
