[TestFixture]
[TestsOf(nameof(Calculator))]
public class CalculatorTests
{
    public class Add : CalculatorTests
    {
        [Test]
        public void AddsTwoNumbersTogether()
        {
            Number sum = Create.Number(4);
            Calculator calculator = CreateCalculator(CreateAdder(sum));

            Number result = calculator.Add(Create.Number(2), Create.Number(2));

            result.Should().Be(sum);
        }
    }

    private Calculator CreateCalculator(IAdder adder = null)
    {
        adder ??= CreateAdder();

        return new Calculator(adder);
    }

    private IAdder CreateAdder(Number toReturn = 1)
    {
        IAdder adder = Substitute.For<IAdder>();
        adder.Add(Arg.Any<Number>(), Arg.Any<Number>()).Returns(toReturn);

        return adder;
    }
}














public class Calculator
{
    private readonly IAdder _adder;

    public Calculator(IAdder adder)
    {
        _adder = adder;
    }
}

public interface IAdder
{
    int Add(int a, int b);
}

public class Number
{
    public Number(int value)
    {
        Value = value;
    }

    public int Value { get; }
}

public static class Create
{
    public Number Number(int value)
    {
        return new Number(value);
    }
}