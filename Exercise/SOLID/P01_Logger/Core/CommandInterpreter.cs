using P01_Logger.Layouts.Factory;
using P01_Logger.Layouts.Factory.Contracts;
using P01_Logger.Loggers.Enums;
using System;

namespace P01_Logger.Core
{
    using Appenders.Contracts;
    using Appenders.Factory;
    using Appenders.Factory.Contracts;
    using Contracts;
    using System.Collections.Generic;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly ICollection<IAppender> _appenders;
        private readonly IAppenderFactory _appenderFactory;
        private readonly ILayoutFactory _layoutFactory;

        public CommandInterpreter()
        {
            _appenders = new List<IAppender>();
            _appenderFactory = new AppenderFactory();
            _layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            var appenderType = args[0];
            var layoutType = args[1];
            var reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            var layout = _layoutFactory.CreateLayout(layoutType);
            var appender = _appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;
            _appenders.Add(appender);
        }

        public void AdMessage(string[] args)
        {
            var reportLevel = Enum.Parse<ReportLevel>(args[0]);
            var dateTime = args[1];
            var message = args[2];

            foreach (var appender in _appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");
            foreach (var appender in _appenders)
            {
                Console.WriteLine(appender.ToString());
            }
        }
    }
}