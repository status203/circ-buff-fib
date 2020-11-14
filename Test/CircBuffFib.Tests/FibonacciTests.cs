using System.Linq;
using CircBuffFib;
using NUnit.Framework;

public class FibonacciTests {
    [TestCase(0, 0, 0, 0, 0)]
    [TestCase(0, 1, 1, 2, 3, 5, 8, 13)]
    [TestCase(1, 3, 4, 7, 11, 18)]
    public void Sequence_StartingWith_HasExpectedInitialEntries(int first, int second, params int[] rest)
    {
        var expected = rest.Prepend(second).Prepend(first);
        var result = Fibonacci.Sequence(first, second).Take(expected.Count());

        Assert.That(result, Is.EqualTo(expected));
    }
}