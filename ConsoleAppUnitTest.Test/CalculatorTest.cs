using FakeItEasy;
using FluentAssertions;
using System.Numerics;

namespace ConsoleAppUnitTest.Test;

public class CalculatorTest
{
    private readonly Calculator _calculator;
    private readonly IIngectableService _ingectableService;
    public CalculatorTest()
    {
        _ingectableService = A.Fake<IIngectableService>();
        _calculator = new Calculator(_ingectableService);
    }

    [Theory]
    [InlineData(5,5,10)]
    [InlineData(-1,-1,-2)]
    [InlineData(0,0,0)]
    public void CalcSum_ShouldSuccess_ReturnInteger(int num1, int num2, int expected)
    {
        var result = _calculator.Sum(num1, num2);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(-1,0,1)]
    public void CalcSum_ShouldFail_ReturnInteger(int num1, int num2, int expected)
    {
        var result = _calculator.Sum(num1, num2);
        result.Should().NotBe(expected);
    }

    [Fact]
    public void Calculator_WhoAmI_ShouldReturnNotEmptyString()
    {
        A.CallTo(() => _ingectableService.WhoAmI()).Returns("Eslam Magdy");
        var result = _calculator.WhoAmI();
        result.Should().NotBeEmpty();
    }

    [Fact]
    public void Calculator_WhoAmI_ShouldReturnEmptyString()
    {
        var result = _calculator.WhoAmI();
        result.Should().BeEmpty();
    }
}