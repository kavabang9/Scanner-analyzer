namespace Scanner_analyzer.Components
{
    public class InformationNetwork : IMethods
    {
        private string? computerName;
        public void Collect()
        {
            throw new NotImplementedException();
        }

        public void OutputInformation()
        {
            computerName = Environment.MachineName;
            Console.WriteLine("\nИнформация о сети");
            Console.WriteLine($"\nИмя компьютера: {computerName}");
            Console.WriteLine();
        }
    }
}