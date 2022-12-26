namespace PracticalTask_10_5
{
    public class Adder : IAdder, IWorker
    {
        double FirstTerm { get; set; }
        double SecondTerm { get; set; }
        public ILogger Logger { get; }
        public Adder(ILogger logger)
        {
            Logger = logger;
        }

        public double Sum(double firstTerm, double secondTerm)
        {
            FirstTerm = firstTerm;
            SecondTerm = secondTerm;    
            return firstTerm + secondTerm;
        }

        public void Work()
        {
            Logger.Event($"Произошло событие, сложение двух чисел {FirstTerm} и {SecondTerm} ...");
        }
    }    
}
