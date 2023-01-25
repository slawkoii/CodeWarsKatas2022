using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
           for(int i = 0; i < n; i++)
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

            if( int.TryParse(s2, out int result2))
                response +=result2;
            else response += 0;  
            
            return response.ToString();
        }

        public static string AreYouPlayingBanjo(string name) =>
            (char.ToLower(name[0]).Equals('r')) ? name + " plays banjo" : name + " does not play banjo";

        public static string buildString(string[] args) => String.Format("I like {0}!", String.Join(", ", args));        
           
        

    }
}
