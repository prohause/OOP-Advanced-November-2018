using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders.Contracts
{
    public interface IAppender
    {
        ReportLevel ReportLevel
        {
            get; set;
        }

        int MessagesCount
        {
            get;
        }

        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}