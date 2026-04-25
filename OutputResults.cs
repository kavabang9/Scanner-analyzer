using Scanner_analyzer.Components;

namespace Scanner_analyzer
{
    public class OutputResults
    {
        public void ShowResults()
        {
            Console.WriteLine("Сканер операционной системы");

            IMethods[] modules =
            {
                new InformationOS(),
                new InformationNetwork(),
                new InformationUsers(),
                new InformationServices(),
                new InformationEventLog()
            };

            foreach (var module in modules)
            {
                module.Collect();
                module.OutputInformation();
            }
        }
    }
}