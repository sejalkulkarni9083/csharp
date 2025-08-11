using System;
using System.Collections.Generic;
using System.Linq;

using AsyncApp.Helper;
//direct call
/*
decimal incomeTax = TaxManager.CalculateIncomeTax(150000);
decimal salesTax = TaxManager.CalculateSalesTax(1000);
decimal propertyTax = TaxManager.CalculatePropertyTax(300000);
Console.WriteLine($"Income Tax: {incomeTax:C}");
Console.WriteLine($"Sales Tax: {salesTax:C}");
Console. WriteLine($"Property Tax: {propertyTax:C}");
*/



//indirect call

//create instance of delegate
// attaching methods to the delegate

TaxCalculationDelegate incometaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateIncomeTax);
TaxCalculationDelegate salesTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateSalesTax);
TaxCalculationDelegate propertyTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculatePropertyTax);

TaxCalculationDelegate capitalGainsTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateCapitalGainTax);
TaxCalculationDelegate corporateTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateCorporateTax);
TaxCalculationDelegate wealthTaxCalculation = new TaxCalculationDelegate(TaxManager.CalculateWealthTax);
//invoke delegate
decimal amount = 500000;

//invoke delegate
//dynamically invoke the delegate

TaxCalculationDelegate proxyTaxCalculator = incometaxCalculation;
//(+=) multicast delegate
//attach Additional delegates to proxyTaxcalculator
TaxCalculationDelegate += salesTaxCalculation;
TaxCalculationDelegate += propertyTaxCalculation;
TaxCalculationDelegate += capitalGainsTaxCalculation;
TaxCalculationDelegate += corporateTaxCalculation;
TaxCalculationDelegate += wealthTaxCalculation;
// establishing chain of delegates


//invoke all delegates
//initiate a chain reaction by invoking a proxy delegate

//proxyTaxCalculator.DynamicInvoke(amount);

//Asynchronous invocation
IAsyncResult asyncResult = proxyTaxCalculator.BeginInvoke(amount, null, null);

//wait for the result
asyncResult.AsyncWaitHandle.WaitOne();

//get the result
decimal result = proxyTaxCalculator.EndInvoke(asyncResult);
Console.WriteLine($"Total Tax: {result}");