namespace P01_BoxOfString.Models
{
    public class Box<T>
    {
        private readonly T _item;

        public Box(T item)
        {
            _item = item;
        }

        public override string ToString()
        {
            return $"{_item.GetType()}: {_item.ToString()}";
        }
    }
}