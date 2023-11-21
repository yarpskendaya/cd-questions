public class CalculatorTests
{
    private TestScope _scope = new();

    [Test]
    public void AddsTwoNumbers()
    {
        _scope.WhenAddingTwoNumbers(1, 2);
        _scope.TheResultShouldBe(3);
    }
}

public class TestScope
{
    private Calculator _calculator = new();
    private int sum;

    public void WhenAddingTwoNumbers(int a, int b)
    {
        sum = _calculator.Add(a, b);
    }

    public void TheResultShouldBe(int expected)
    {
        Assert.AreEqual(expected, sum);
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}