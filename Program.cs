// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Numerics;

namespace CodeWarsKatas2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] toShow = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            string toShow = ArrayKatas.MultiTable(2);
           // for (int i = 0; i < toShow.Length; i++)
            //{
           //     Console.WriteLine(toShow[i]);
           // }
            Console.WriteLine(StringKatas.getNumberFromString("this is number: 7"));
            Console.WriteLine("Koniec");
            
        }
    }
}
