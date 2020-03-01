using System;

namespace csharp_text_analyser_chashafe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the name of the file");
            var z = Console.ReadLine();
            FileContent newFileContent = new FileContent(z);
            WordIterator newWordITerator = new WordIterator(newFileContent);
            StatisticalAnalysis newStatAnalys = new StatisticalAnalysis(newWordITerator);
            view newView = new view();
            // StatisticalAnalysis u = new StatisticalAnalysis(this);
            Console.WriteLine("Hello World!");
        }
    }
}
