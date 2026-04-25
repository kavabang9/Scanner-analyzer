namespace Scanner_analyzer.Components
{
    public class InformationNetwork : IMethods
    {
        private string? computerName;
        private string? userName;
        public void Collect()
        {
            computerName = Environment.MachineName;
            userName = Environment.UserName;
        }

        public void OutputInformation()
        {
            computerName = Environment.MachineName;
            Console.WriteLine("\nИнформация о сети");
            Console.WriteLine($"\nИмя компьютера: {computerName}");
            Console.WriteLine($"Имя пользователя: {userName}");
            Console.WriteLine();
        }
    }
}