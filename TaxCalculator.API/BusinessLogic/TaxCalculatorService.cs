using TaxCalculator.API.BusinessLogic.Interfaces;

namespace TaxCalculator.API.BusinessLogic
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly Dictionary<string, ITaxCalculator> _taxCalculators;

        public TaxCalculatorService()
        {
            _taxCalculators = new Dictionary<string, ITaxCalculator>
        {
            { "7441", new ProgressiveTaxCalculator() },
            { "1000", new ProgressiveTaxCalculator() },
            { "A100", new FlatValueTaxCalculator() },
            { "7000", new FlatRateTaxCalculator() }
        };
        }

        public decimal CalculateTax(string postalCode, decimal annualSalary)
        {
            if (_taxCalculators.TryGetValue(postalCode, out ITaxCalculator calculator))
            {
                return calculator.CalculateTax(annualSalary);
            }

            throw new ArgumentException("Invalid postal code");
        }
    }

}
