namespace FizzBuzzLibrary;

public interface IFizzBuzz
{
    void ProcessClassicFizzBuzz();
    void ProcessTwistedFizzBuzzSequential(long initNumber, long finalNumber, Dictionary<long, string> tokens);
    void ProcessTwistedFizzBuzzNonSequential(List<long> numbers, Dictionary<long, string> tokens);
}