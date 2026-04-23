namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var os = Environment.OSVersion;
            Console.WriteLine($"Платформа: {os.Platform}");
            Console.WriteLine($"Версия: {os.Version}");
            Console.WriteLine($"Полная строка: {os.VersionString}");
        }
    }
}
