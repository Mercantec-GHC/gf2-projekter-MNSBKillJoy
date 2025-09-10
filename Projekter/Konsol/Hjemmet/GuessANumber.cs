namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Guess a number between 1 and 100000");

            Random brains = new Random();
            int brainsnum = brains.Next(1, 100000);

            Console.WriteLine($"The brain may be thinking of {brainsum}");

            Console.ReadKey();
        }
    }
}
