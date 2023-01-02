namespace ConsoleAppUnitTest;

public class Calculator
{
    private readonly IIngectableService _ingectableService;
    public Calculator(IIngectableService ingectableService)
    {
        _ingectableService = ingectableService;
    }

    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Def(int num1, int num2)
    {
        return num1 - num2;
    }

    public decimal? Div(int num1, int num2)
    {
        if (num2 == 0) return null;
        return num1 / num2;
    }

    public int Mul(int num1, int num2)
    {
        return num1 * num2;
    }

    public string WhoAmI()
    {
        return _ingectableService.WhoAmI();
    }
}