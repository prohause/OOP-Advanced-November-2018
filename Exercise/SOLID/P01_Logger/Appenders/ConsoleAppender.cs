using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    using Layouts.Contracts;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel < ReportLevel)
            {
                return;
            }

            Console.WriteLine(string.Format(base.Layout.Format, dateTime, reportLevel, message));
            MessagesCount++;
        }

        public override string ToString()
        {
            return
                $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel}, Messages appended: {MessagesCount}";
        }
    }
}