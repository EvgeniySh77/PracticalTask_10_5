using System;

namespace PracticalTask_10_5
{
    internal partial class Program
    {
        static void Main()
        {
            bool selector = true;
            var reader = new NumberReader();
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

                    IAdder adder = new Adder();
                    Console.WriteLine(new string('-', 30));
                    Console.WriteLine($"{firstSunnand} + {secondSunnand} " +
                        $"= {adder.Sum(firstSunnand, secondSunnand)}");

                    selector = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    selector = true;
                }
            }            

            Console.ReadKey();
        }
    }
}
