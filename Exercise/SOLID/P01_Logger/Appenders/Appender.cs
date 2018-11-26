using P01_Logger.Appenders.Contracts;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        private readonly ILayout _layout;

        public ReportLevel ReportLevel
        {
            get; set;
        }

        public int MessagesCount
        {
            get; protected set;
        }

        protected ILayout Layout => _layout;

        protected Appender(ILayout layout)
        {
            _layout = layout;
            MessagesCount = 0;
        }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}