using System.Diagnostics;

namespace Scanner_analyzer.Components
{
    internal class InformationEventLog : IMethods
    {
        public void Collect() { }

        public void OutputInformation()
        {
            Console.WriteLine("Последние ошибки системы\n");

            EventLog systemLog = new EventLog("System");

            int count = 0;

            for (int i = systemLog.Entries.Count - 1; i >= 0 && count < 10; i--)
            {
                EventLogEntry entry = systemLog.Entries[i];

                if (entry.EntryType == EventLogEntryType.Error)
                {
                    Console.WriteLine($"Источник: {entry.Source}");
                    Console.WriteLine($"Сообщение: {entry.Message}");
                    Console.WriteLine($"Дата: {entry.TimeGenerated}");
                    Console.WriteLine();
                    count++;
                }
            }
        }
    }
}
