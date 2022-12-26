using System;

namespace PracticalTask_10_5
{
    internal partial class Program
    {
        static ILogger Logger { get; set; }
        static void Main()
        {
            bool selector = true;
            Logger = new Logger();
            var reader = new NumberReader(Logger);
            while (selector)
            {
                try
                {
                    Console.Write("Введите первое слагаемое - ");
                    reader.Summand = Console.ReadLine();
                    double firstSunnand = reader.Read();

                    Console.Write("Введите второе слагаемое - ");
                    reader.Summand = Console.ReadLine();
                    double secondSunnand = reader.Read();

                    var adder = new Adder(Logger);
                    Console.WriteLine(new string('-', 30));
                    Console.WriteLine($"{firstSunnand} + {secondSunnand} " +
                        $"= {adder.Sum(firstSunnand, secondSunnand)}");
                    adder.Work();

                    selector = false;
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine(ex.Message);
                    reader.Work();
                    selector = true;
                }
            }

            Console.ReadKey();
        }
    }
}
