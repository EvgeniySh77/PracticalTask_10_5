using System;

namespace PracticalTask_10_5
{
    public class NumberReader
    {
        double summand;
        public string Summand { get; set; } 

        public double Read()
        {
            if (double.TryParse(Summand, out double summand))
                return summand;
            else
                throw new ArgumentException("Ошибка: неверный ввод...");
        }
    }
}
