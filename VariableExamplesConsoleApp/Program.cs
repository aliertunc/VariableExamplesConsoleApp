using VariableExamplesConsoleApp.Examples;

namespace VariableExamplesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Kolay Seviye ###");
            EasyExamples easy = new EasyExamples();
            easy.Run();

            Console.WriteLine("\n### Orta Seviye ###");
            MediumExamples medium = new MediumExamples();
            medium.Run();

            Console.WriteLine("\n### Zor Seviye ###");
            HardExamples hard = new HardExamples();
            hard.Run();
        }
    }
}
