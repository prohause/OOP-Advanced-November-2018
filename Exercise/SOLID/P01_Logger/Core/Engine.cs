namespace P01_Logger.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter _commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            _commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputArguments = Console.ReadLine().Split(" ");
                _commandInterpreter.AddAppender(inputArguments);
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split("|");
                _commandInterpreter.AdMessage(args);
            }

            _commandInterpreter.PrintInfo();
        }
    }
}