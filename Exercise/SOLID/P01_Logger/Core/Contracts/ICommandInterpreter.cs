namespace P01_Logger.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void AdMessage(string[] args);

        void PrintInfo();
    }
}