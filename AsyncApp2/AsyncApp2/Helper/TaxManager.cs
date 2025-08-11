using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApp2.Helper
{
    public delegate decimal TaxCalculationDelegate(decimal amount);
    public class TaxManager
    {
        public static decimal CalculateIncomeTax(decimal income)
        {
            decimal taxRate = 0.2m;
            return income * taxRate;
        }
        public static decimal CalculateSalesTax(decimal amount)
        {
            decimal taxRate = 0.07m; // 7% sales tax
            return amount * taxRate;
        }
        public static decimal CalculatePropertyTax(decimal propertyValue)
        {
            decimal taxRate = 0.015m; // 1.5% property tax
            return propertyValue * taxRate;
        }
        public static decimal CalculateCapitalGainTax(decimal capitalGains)
        {
            decimal capitalGainTaxRate = 0.15m;
            return capitalGains * capitalGainTaxRate;

        }
        public static decimal CalculateCorporateTax(decimal corporateIncome)
        {
            decimal corporateTaxRate = 0.25m;
            return corporateIncome * corporateTaxRate;
        }

        public static decimal CalculateWealthTax(decimal netWorth)
        {
            decimal wealthTaxRate = 0.01m;
            return netWorth * wealthTaxRate;
        }
    }
}