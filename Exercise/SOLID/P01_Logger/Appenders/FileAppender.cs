using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Contracts;
using P01_Logger.Loggers.Enums;
using System;
using System.IO;

namespace P01_Logger.Appenders
{
    public class FileAppender : Appender
    {
        private const string Path = "log.txt";
        private readonly ILogFile _logFile;

        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            _logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            var content = string.Format(base.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
            if (reportLevel < ReportLevel)
            {
                return;
            }

            _logFile.Write(content);
            File.AppendAllText(Path, content);
            MessagesCount++;
        }

        public override string ToString()
        {
            return
                $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel}, Messages appended: {MessagesCount}, File size: {_logFile.Size}";
        }
    }
}