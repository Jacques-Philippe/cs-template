using NUnit.Framework;

namespace Add.Tests;

public class OperationsTests
{
    [Test]
    public void AddingTwoNumbersShouldReturnTheirSum()
    {
        Assert.That(Add.Operations.Add(1, 2) == 3);
    }

    [Test]
    public void AddingANumberAndItsNegativeShouldBeZero()
    {
        var number = 1;
        Assert.That(Add.Operations.Add(number, -number) == 0);
    }
}
