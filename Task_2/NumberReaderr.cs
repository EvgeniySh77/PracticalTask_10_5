using System;

namespace PracticalTask_10_5
{
    public class NumberReader : IWorker
    {
        public ILogger Logger { get; }
        public NumberReader(ILogger logger)
        {
            Logger = logger;
        }
        public string Summand { get; set; } 

        public double Read()
        {
            if (double.TryParse(Summand, out double summand))
                return summand;
            else
            { 
                throw new ArgumentException("Ошибка: неверный ввод...");
            }
        }

        public void Work()
        {
            Logger.Error("Произошла ошибка в методе Read() на объекте класса NumberReader строка 16...");
        }
    }
}
