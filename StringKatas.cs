using System.Text.RegularExpressions;

namespace CodeWarsKatas2022
{
    public class StringKatas
    {
        public static object[] IsVow(object[] a)
        {
            int[] vowelsCodesTabel = new int[5] { (int)'a', (int)'e', (int)'i', (int)'o', (int)'u' };

            for (int i = 0; i < a.Length; i++)
            {
                if (vowelsCodesTabel.Contains((int)a[i])) a[i] = Convert.ToChar(a[i]).ToString();
            }
            return a;
        }
        public static string MakeComplement(string dna) => dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();

        public static string NameShuffler(string str)
        {
            string[] names = str.Split(" ");

            return names[1] + " " + names[0];
        }

        public static bool Feast(string beast, string dish) => ((beast.Substring(0, 1) == dish.Substring(0, 1)) && (beast.Substring(beast.Length - 1, 1) == (dish.Substring(dish.Length - 1, 1))));

        public static string RepeatStr(int n, string s)
        {
            string response = string.Empty;
            for (int i = 0; i < n; i++)
                response += s;
            return response;
        }

        public static int ConsonantCount(string str)
        {
            str = Regex.Replace(str, "[a e i o u 0-9 .,()!#$%&'*+/=?^_`{|}~-]", string.Empty);
            return str.Length;
        }

        public static string StringsSum(string s1, string s2)
        {
            int response = 0;
            if (int.TryParse(s1, out int result1))
                response += result1;
            else response += 0;

            if (int.TryParse(s2, out int result2))
                response += result2;
            else response += 0;

            return response.ToString();
        }

        public static string AreYouPlayingBanjo(string name) =>
            (char.ToLower(name[0]).Equals('r')) ? name + " plays banjo" : name + " does not play banjo";

        public static string buildString(string[] args) => String.Format("I like {0}!", String.Join(", ", args));

        public static bool IsOpposite(string s1, string s2)
        {
            return s1 != string.Empty && string.Concat(s1.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x))) == s2;
        }

        //returnig numbers only from the string 
        public static int GetNumberFromString(string s)
        {

            var response = string.Join(null, Regex.Split(s, "[^\\d]"));
            _ = int.TryParse(response, out int result);
            return result;
        }

        // only lower case, numbers and underscore allowed to input. Lenght is from 4 to 16 
        public static bool ValidateUsr(string username) =>
            Regex.IsMatch(username, @"^[a-z0-9_]{4,16}$");

        public static bool Digit(string s) => Regex.IsMatch(s, "^[0-9]$");

        public static string StringClean(string s) => string.Join(null, Regex.Split(s, "[0-9]"));

        public static int LowercaseCountCheck(string s) => String.Join(null, Regex.Matches(s, "[a-z]")).Length;

        public static int LowercaseCountCheck2(string s) => s.Count(c => char.IsLower(c));

        public static bool IsLockNessMonster(string sentence)
        {
            string pattern = "( tree fiddy|3.50|three fifty)";
            return Regex.IsMatch(sentence, pattern, RegexOptions.IgnoreCase);
        }

        public static string FormatMoney(double amount) =>
            "$" + amount.ToString("F2", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        public static string ShortLongShort(string a, string b) => (a.Length >= b.Length) ? b + a + b : a + b + a;

        readonly string[] Deck =
        {
           "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
           "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
           "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
           "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
        };

        public static string DefineSuit(string card)
        {
            switch (card.Substring(card.Length - 1, 1))
            {
                case "♣": return "clubs";
                case "♦": return "diamonds";
                case "♥": return "hearts";
                default: break;
            }
            return "spades";
        }

        public static string SayHello(string[] name, string city, string state)
        {
            string fullName = string.Join(" ", name);
            return $"Hello, {fullName}! Welcome to {city}, {state}!";
        }

        public static string ArrowFunc(int[] arr)
        {
            return string.Join("", arr.Select(c => Convert.ToChar(c)).ToArray());
        }

        public static string ArrowFuncVersion2(int[] arr)
        {
            string response = string.Empty;
            foreach (var number in arr)
            {
                response += Convert.ToChar(number);
            }
            return response;
        }

        public static string Remove(string s) =>
            s.Substring(s.Length - 1, 1) == "!" ? s.Substring(0, s.Length - 1) : s;



    }
}
