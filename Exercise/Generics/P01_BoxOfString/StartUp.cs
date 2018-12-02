namespace P01_BoxOfString
{
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var myList = new List<string>();

            var lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                var input = Console.ReadLine();
                myList.Add(input);
            }

            var myBox = new Box<string>(myList);
            var tokens = Console.ReadLine().Split(" ");
            var index1 = int.Parse(tokens[0]);
            var index2 = int.Parse(tokens[1]);
            myBox.Swap(index1, index2);

            Console.WriteLine(myBox.ToString());
        }
    }
}