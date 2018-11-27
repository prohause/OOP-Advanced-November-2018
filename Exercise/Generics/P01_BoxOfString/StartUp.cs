namespace P01_BoxOfString
{
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IList<Box<int>> myList = new List<Box<int>>();

            var lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                var input = int.Parse(Console.ReadLine());
                myList.Add(new Box<int>(input));
            }

            foreach (var box in myList)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}