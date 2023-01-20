using System;
namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många namn vill du skriva in?");
            int namn = int.Parse(Console.ReadLine());
            string[] namner = new string[namn];

            for (int i = 0; i < namn; i++)
            {
                Console.WriteLine("Skriv in nämnerna");
                namner[i] = Console.ReadLine();
            }

            Console.WriteLine("Här är de nämnen du skrev in");
            for (int i = 0; i < namn; i++)
            {
                Console.WriteLine(namner[i]);
            }
        }
    }
}
