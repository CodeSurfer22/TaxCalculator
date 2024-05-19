namespace TaxCalculator.API.BusinessLogic.Interfaces
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal annualSalary);
    }

}
