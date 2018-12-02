using System.Collections.Generic;
using System.Text;

namespace P01_BoxOfString.Models
{
    public class Box<T>
    {
        public List<T> Items
        {
            get; set;
        }

        public Box(List<T> items)
        {
            Items = items;
        }

        public void Swap(int index1, int index2)
        {
            var firstElement = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = firstElement;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.Append($"{item.GetType().FullName}: {item.ToString()}\n");
            }

            return sb.ToString().TrimEnd();
        }
    }
}