using System.Collections.Generic;

namespace P03_Generic_Swap.Methods
{
    public class Generic
    {
        public static IList<T> Swap<T>(IList<T> collection, int firstIndex, int secondIndex)
        {
            var firstElement = collection[firstIndex];
            var secondElement = collection[secondIndex];
            collection[secondIndex] = firstElement;
            collection[firstIndex] = secondElement;

            return collection;
        }
    }
}