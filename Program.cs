using System;
using System.Threading;
using System.Threading.Tasks;


namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SampleLibrary.Utility.Echo("Here we go!!!");
            var cities = new string[] {"LosAngeles", "NewYork", "SanFrancisco"};

            Parallel.ForEach(cities, c => 
            { 
                Thread.Sleep(1000);
                Console.WriteLine(c);
            });
            Console.WriteLine("Done Parallel For");

            foreach (var c in cities)
            {
                Task.Run(()=>
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine(c);
                    });
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        } 
    }
}
