using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Formats.Asn1;

namespace CodeWarsKatas2022
{
    public class BaisicKatas
    {
        
        public static string SwitchItUp(int number)
        {
            Dictionary<int, string> numbers = new()
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

        // Write a static function "Square" here which takes a double
        // and returns the square of that double
        public static double Square(double a) => Math.Pow(a, 2);

        public static int Litres(double time) => (int)Math.Round(time * 0.5, MidpointRounding.ToNegativeInfinity);

        public static int HowManyLightsabersDoYouOwn(string name) => name == "Zach" ? 18 : 0;

        public static int Mango(int quantity, int price) => (quantity - (int)Math.Round((decimal)quantity / 3)) * price;

        public static Dictionary<string, string> Mystery() => new() { { "sanity", "hello" } };

        public static int SaleHotDogs(int n) => n < 5 ? 100 * n : (n >= 5 && n < 10) ? n * 95 : n * 90;

        public static bool CheckForFactor(int num, int factor) => num % factor == 0;

        public static string WhatDay(int n)
        {
            Dictionary<int, string> weekdays = new()
            {
                {1, "Sunday"}, {2,"Monday"}, {3,"Tuesday"}, {4, "Wednesday"}, {5,"Thursday"}, {6,"Friday"}, {7,"Saturday"},
            };
            if (weekdays.TryGetValue(n, out string result)) return result;
            else return "Wrong, please enter a number between 1 and 7";          
        }

        public static uint Hotpo(uint n)
        {
            uint count = 0;
            while (n != 1)
            {
                if (n % 2 == 0) n /= 2;
                else n = 3 * n + 1;
                count++;
            }
            return count;
        }

        public static double EvalObject(double value1, double value2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+': return _ = value1 + value2;
                case '-': return _ = value1 - value2;
                case '/': return _ = value1 / value2;
                case '*': return _ = value1 * value2;
                case '%': return _ = value1 % value2;
                case '^': return _ = Math.Pow(value1, value2);
                default:
                    break;
            }
            return result;
        }

        public static int binToDec(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    result += (int)Math.Pow(2, s.Length - i - 1);
                }
            }
            return result;
        }

        public static string ChromosomeCheck(string sperm) =>
            sperm == "XX" ? "Congratulations! You're going to have a daughter." : "Congratulations! You're going to have a son.";

        public static bool AmIWilson(int p)
        {
            double silnia = 1;
            for(int i = p - 1; i > 1; i--)
            {
                silnia *= i;
            }
            double result = (silnia + 1) / (p * p);

            return (int)result == result;
        }

        public static object Animals(int heads, int legs)
        {
            if (legs % 2 != 0)
                return "No solutions";

            int cows = legs / 2 - heads;
            int chickens = heads - cows;

            return (cows < 0 || chickens < 0) ? (object)"No solutions" : new int[2] { chickens, cows };
        }

        public static object PlayerRankUp(int points) => (points >= 100)         
            ? "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up." : false;

    }

    
}
