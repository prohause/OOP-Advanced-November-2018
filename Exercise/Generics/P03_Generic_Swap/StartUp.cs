using P01_BoxOfString.Models;
using P03_Generic_Swap.Methods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Generic_Swap
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IList<Box<string>> myCollection = new List<Box<string>>();
            var lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                var input = Console.ReadLine();
                myCollection.Add(new Box<string>(input));
            }

            var indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var firstIndex = indexes[0];
            var secondIndex = indexes[0];

            myCollection = Generic.Swap(myCollection, firstIndex, secondIndex);
            foreach (var box in myCollection)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}