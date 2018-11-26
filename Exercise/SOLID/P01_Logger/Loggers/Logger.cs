using P01_Logger.Loggers.Enums;

namespace P01_Logger.Loggers
{
    using Appenders.Contracts;
    using Contracts;

    public class Logger : ILogger
    {
        private readonly IAppender _consoleAppender;
        private readonly IAppender _fileAppender;

        public Logger(IAppender consoleAppender)
        {
            _consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender) : this(consoleAppender)
        {
            _fileAppender = fileAppender;
        }

        public void Info(string dateTime, string infoMessage)
        {
            AppendMessage(dateTime, ReportLevel.INFO, infoMessage);
        }

        public void Warning(string dateTime, string errorMessage)
        {
            AppendMessage(dateTime, ReportLevel.WARNING, errorMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            AppendMessage(dateTime, ReportLevel.ERROR, errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            AppendMessage(dateTime, ReportLevel.CRITICAL, criticalMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            AppendMessage(dateTime, ReportLevel.FATAL, fatalMessage);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            _consoleAppender?.Append(dateTime, reportLevel, message);

            _fileAppender?.Append(dateTime, reportLevel, message);
        }
    }
}