using System.Linq;

namespace P01_Logger.Loggers
{
    using Contracts;

    public class LogFile : ILogFile
    {
        public int Size
        {
            get;
            private set;
        }

        public void Write(string message)
        {
            Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}