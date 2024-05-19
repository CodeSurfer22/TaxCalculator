using TaxCalculator.API.BusinessLogic;

[TestFixture]
public class FlatRateTaxCalculatorTests
{
    [TestCase(100000, 17500)]
    [TestCase(200000, 35000)]
    [TestCase(500000, 87500)]
    public void CalculateTax_ReturnsCorrectTax(decimal annualSalary, decimal expectedTax)
    {
        var calculator = new FlatRateTaxCalculator();
        var tax = calculator.CalculateTax(annualSalary);
        Assert.AreEqual(expectedTax, tax);
    }
}
