using P01_Logger.Loggers;
using System;

namespace P01_Logger.Appenders.Factory
{
    using Appenders.Contracts;
    using Contracts;
    using Layouts.Contracts;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeToLowerCase = type.ToLower();

            switch (typeToLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);

                case "fileappender":
                    return new FileAppender(layout, new LogFile());

                default:
                    throw new ArgumentException("Invalid appender type");
            }
        }
    }
}