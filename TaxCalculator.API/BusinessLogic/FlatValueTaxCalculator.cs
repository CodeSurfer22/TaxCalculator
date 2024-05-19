using TaxCalculator.API.BusinessLogic.Interfaces;

namespace TaxCalculator.API.BusinessLogic
{
    public class FlatValueTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal annualSalary)
        {
            if (annualSalary < 200000)
                return annualSalary * 0.05m;
            else
                return 10000;
        }
    }

}
