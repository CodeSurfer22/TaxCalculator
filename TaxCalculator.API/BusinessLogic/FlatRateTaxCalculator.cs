using TaxCalculator.API.BusinessLogic.Interfaces;

namespace TaxCalculator.API.BusinessLogic
{
    public class FlatRateTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal annualSalary)
        {
            return annualSalary * 0.175m;
        }
    }

}
