//System.Threading.Thread.Sleep(10000); // raw level multithraeading ......Simulating some work before printing the message
/*using System.Threading.Tasks;


Console.WriteLine("welcome to transflower.....");
Task.Delay(10000).Wait(); // Simulating some work before printing the message
Console.WriteLine("Hello,World");
Console.WriteLine("Press any key to exit!.....");*/

using AsyncAwaitDemoApp.Entities;
using AsyncAwaitDemoApp.Helper;


//Example usage of GetAdharId
string panCardId = "ABZPT0595R";
string adharId = await TaxDeductionManager.GetAdharId(panCardId);
Console.WriteLine($"Adhar ID for PAN {panCardId} is: {adharId}");

decimal incomeTax = await TaxDeductionManager.CalculateIncomeTax(750000);
Console.WriteLine($"Income Tax :{incomeTax}");


List<Product> allProducts = await TaxDeductionManager.GetAllAvailableProducts();
Console.WriteLine("Available Products:");
foreach (var product in allProducts)
{
    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, Category: {product.Category}, Quantity: {product.Quantity}");
}

string message = await TaxDeductionManager.ParallelBackgroundTasks();
Console.WriteLine(message);