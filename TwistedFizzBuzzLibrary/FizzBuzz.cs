namespace FizzBuzzLibrary;

public class FizzBuzz : IFizzBuzz
{
    public void ProcessClassicFizzBuzz()
    {
        var tokens = new Dictionary<long, string> { {3, "Fizz"}, {5, "Buzz"}};
        for (long i = 1; i <= 100; i++)
        {
            PrintFizzBuzz(i, tokens);
        }
    }

    public void ProcessTwistedFizzBuzzSequential(long initNumber, long finalNumber, Dictionary<long, string> tokens)
    {
        if (finalNumber > initNumber)
        {
            for (var i = initNumber; i <= finalNumber; i++)
            {
                PrintFizzBuzz(i, tokens);
            }
        }
        else
        {
            for (var i = initNumber; i >= finalNumber; i--)
            {
                PrintFizzBuzz(i, tokens);
            }
        }
    }

    public void ProcessTwistedFizzBuzzNonSequential(List<long> numbers, Dictionary<long, string> tokens)
    {
        foreach (var number in numbers)
        {
            PrintFizzBuzz(number, tokens);   
        }
    }

    private void PrintFizzBuzz(long i, Dictionary<long, string> tokens)
    {
        var output = string.Empty;
        foreach (var token in tokens)
        {
            if (i % token.Key == 0)
            {
                output += token.Value;
            }
        }

        if (output == string.Empty)
        {
            output = i.ToString();
        }
        Console.WriteLine(output);
    }
}