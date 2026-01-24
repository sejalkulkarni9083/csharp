using Hr;
SalesManager salesManager = new SalesManager(   1, "Sanika", "kulkarni", 60000, 7000, 150000, 10000);

SalesEmployee salesEmployee = new SalesEmployee( 2, "Sejal","kulkarni", 60000, 7000, 150000);

   

salesManager.Achieved = 160000;

Console.WriteLine(salesManager.ToString());
Console.WriteLine(salesEmployee.ToString());
salesManager.DoWork();
salesEmployee.DoWork();
double totalPay = salesManager.ComputePay();
Console.WriteLine($"Total Pay: {totalPay}");