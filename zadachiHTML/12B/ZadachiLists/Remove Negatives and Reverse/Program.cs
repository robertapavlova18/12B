using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        private static int item;

        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();

            foreach (var item in num)
            {
                if (item > 0)
                {
                    numbers.Add(item);
                }
            }
            foreach (var item in num)
            {
                if (item < 0)
                {
                    numbers.Remove(item);
                }
            }
            numbers.Reverse();

            if (numbers.Any()) { Console.WriteLine(string.Join(" ", numbers)); }
            else { Console.WriteLine("empty"); }
        }
    }
}
