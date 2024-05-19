using TaxCalculator.API.BusinessLogic;

[TestFixture]
public class FlatValueTaxCalculatorTests
{
    [TestCase(150000, 7500)]
    [TestCase(200000, 10000)] 
    [TestCase(250000, 10000)] 
    public void CalculateTax_ReturnsCorrectTax(decimal annualSalary, decimal expectedTax)
    {
        var calculator = new FlatValueTaxCalculator();
        var tax = calculator.CalculateTax(annualSalary);
        Assert.AreEqual(expectedTax, tax);
    }
}

