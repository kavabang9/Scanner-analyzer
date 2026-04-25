namespace Scanner_analyzer.Components
{
    public class InformationOS : IMethods
    {
        public string Name { get; private set; }
        public string Version { get; private set; }
        public string Architecture { get; private set; }

        public void Collect()
        {
            Name = Environment.OSVersion.Platform.ToString();
            Version = Environment.OSVersion.Version.ToString();

            if (Environment.Is64BitOperatingSystem)
            {
                Architecture = "x64";
            }
            else
            {
                Architecture = "x86";
            }
        }

        public void OutputInformation()
        {
            string architecture;

            if (Environment.Is64BitOperatingSystem)
            {
                architecture = "x64";
            }
            else
            {
                architecture = "x86";
            }

            Console.WriteLine($"\nОбщая информация о компьютере");
            Console.WriteLine($"\nПлатформа: {Name}");
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Разрядность ОС: {architecture}");
        }
    }
}