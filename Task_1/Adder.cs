namespace PracticalTask_10_5
{
    internal partial class Program
    {
        public class Adder : IAdder
        {
            public double Sum(double firstTerm, double secondTerm)
            {
                return firstTerm + secondTerm;
            }
        }
    }
}
