using Scanner_analyzer.Components;

namespace Scanner_analyzer
{
    public class OutputResults
    {
        public void ShowResults()
        {
            Console.WriteLine("Сканер операционной системы");

            InformationOS informationOS = new InformationOS();
            informationOS.OutputInformation();

            InformationNetwork informationNetwork = new InformationNetwork();
            informationNetwork.OutputInformation();

            InformationUsers informationUsers = new InformationUsers();
            informationUsers.OutputInformation();
        }
    }
}