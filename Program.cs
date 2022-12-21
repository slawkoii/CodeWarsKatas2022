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
            var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
            object[] toShow = ArrayKatas.TakeFirstElements(arr, 3);
            for (int i = 0; i < toShow.Length; i++)
            {
                Console.WriteLine(toShow[i]);
            }


        }
    }
}
