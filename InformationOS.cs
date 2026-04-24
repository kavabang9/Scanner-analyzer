namespace Scanner_analyzer
{
    public class InformationOS
    {
        private OperatingSystem? osBaseInfo;
        private string? osBaseInfoAdd;

        public void OutputInformationOS()
        {
            osBaseInfo = Environment.OSVersion;

            string architecture;

            if (Environment.Is64BitOperatingSystem)
            {
                architecture = "x64";
            }
            else
            {
                architecture = "x86";
            }

            osBaseInfoAdd = Environment.UserName;

            Console.WriteLine($"Платформа: {osBaseInfo.Platform}");
            Console.WriteLine($"Версия: {osBaseInfo.Version}");
            Console.WriteLine($"Полная строка: {osBaseInfo.VersionString}");
            Console.WriteLine($"Разрядность ОС: {architecture}");

            Console.WriteLine($"Имя пользователя: {osBaseInfoAdd}");
        }
    }
}