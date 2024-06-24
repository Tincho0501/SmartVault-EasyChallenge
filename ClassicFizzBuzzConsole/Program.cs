using FizzBuzzLibrary;

namespace ClassicFizzBuzz;

public static class ClassicFizzBuzzConsole
{
    public static void Main()
    {
        Console.WriteLine("This is the Classic Fizz Buzz Problem!");
        IFizzBuzz fizzBuzz = new FizzBuzz();
        fizzBuzz.ProcessClassicFizzBuzz();
    }
}