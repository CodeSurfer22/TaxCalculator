namespace TaxCalculator.API.BusinessLogic.Interfaces
{
    public interface ITaxCalculatorService
    {
        decimal CalculateTax(string postalCode, decimal annualSalary);
    }

}
    