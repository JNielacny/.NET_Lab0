namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FizzBuzz fz1 = new FizzBuzz(20);
            fz1.Display();
        }
    }
}
