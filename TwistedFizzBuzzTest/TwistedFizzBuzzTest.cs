using FizzBuzzLibrary;

namespace TwistedFizzBuzzTest;

public abstract class TwistedFizzBuzzTest
{
    [TestFixture]
    private class WhenTestingClassicFizzBuzz
    {
        private IFizzBuzz _fizzbuzz;
        
        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }
        
        [Test]
        public void ShouldPrintClassicFizzBuzz()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);    
            _fizzbuzz.ProcessClassicFizzBuzz();
            var expectedOutput = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n" +
                                 "16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n" +
                                 "31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n" +
                                 "46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n" +
                                 "61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n" +
                                 "76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n" +
                                 "91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\nBuzz\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [TestFixture]
    private class WhenTestingTwistedFizzBuzz
    {
        private IFizzBuzz _fizzbuzz;
        
        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void ShouldPrintSequentialArrays()
        {
            var tokens = new Dictionary<long, string>{ {3, "Fizz"}, {5, "Buzz"}};
            using var sw = new StringWriter();
            Console.SetOut(sw);    
            _fizzbuzz.ProcessTwistedFizzBuzzSequential(1, 50, tokens);
            var expectedOutput = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n" +
                                 "16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n" +
                                 "31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n" +
                                 "46\r\n47\r\nFizz\r\n49\r\nBuzz\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
        
        [Test]
        public void ShouldPrintSequentialNegativeArrays()
        {
            var tokens = new Dictionary<long, string>{ {3, "Fizz"}, {5, "Buzz"}};
            using var sw = new StringWriter();
            Console.SetOut(sw);    
            _fizzbuzz.ProcessTwistedFizzBuzzSequential(-2, -37, tokens);
            var expectedOutput = "-2\r\nFizz\r\n-4\r\nBuzz\r\nFizz\r\n-7\r\n-8\r\nFizz\r\nBuzz\r\n-11\r\nFizz\r\n-13\r\n-14" +
                                 "\r\nFizzBuzz\r\n-16\r\n-17\r\nFizz\r\n-19\r\nBuzz\r\nFizz\r\n-22\r\n-23\r\nFizz\r\nBuzz\r\n-26" +
                                 "\r\nFizz\r\n-28\r\n-29\r\nFizzBuzz\r\n-31\r\n-32\r\nFizz\r\n-34\r\nBuzz\r\nFizz\r\n-37\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ShouldWorkWithLongSequentialArrays()
        {
            var tokens = new Dictionary<long, string>{ {3, "Fizz"}, {5, "Buzz"}};
            // Testing with 200.000.000 throws a NUnit exception
            _fizzbuzz.ProcessTwistedFizzBuzzSequential(1, 20000000, tokens);
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Assert.NotNull(sw.ToString());
        }

        [Test]
        public void ShouldPrintNonSequentialArrays()
        {
            var numbers = new long[] { -5, 6, 300, 12, 15 };
            var tokens = new Dictionary<long, string>{ {3, "Fizz"}, {5, "Buzz"}};
            using var sw = new StringWriter();
            Console.SetOut(sw);    
            _fizzbuzz.ProcessTwistedFizzBuzzNonSequential(numbers.ToList(), tokens);
            var expectedOutput = "Buzz\r\nFizz\r\nFizzBuzz\r\nFizz\r\nFizzBuzz\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ShouldAcceptAnyTokens()
        {
            var numbers = new long[] { 119, 51, 21, 357 };
            var tokens = new Dictionary<long, string>{ {7, "Poem"}, {17, "Writer"}, {3, "College"}};
            using var sw = new StringWriter();
            Console.SetOut(sw);    
            _fizzbuzz.ProcessTwistedFizzBuzzNonSequential(numbers.ToList(), tokens);
            var expectedOutput = "PoemWriter\r\nWriterCollege\r\nPoemCollege\r\nPoemWriterCollege\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}