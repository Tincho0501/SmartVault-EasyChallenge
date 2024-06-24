using FizzBuzzLibrary;

namespace TwistedFizzBuzzConsole;

public static class TwistedFizzBuzzConsole
{
    public static void Main()
    {
        Console.WriteLine("This is the Twisted Fizz Buzz Problem!");
        IFizzBuzz fizzBuzz = new FizzBuzz();
        var tokens = new Dictionary<long, string> { {5, "Fizz"}, {9, "Buzz"}, {27, "Bar"} };
        fizzBuzz.ProcessTwistedFizzBuzzSequential(-20, 127, tokens);
    }
}