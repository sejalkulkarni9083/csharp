// See https://aka.ms/new-console-template for more information
using Catalog;
int count=45;
count++;
Console.WriteLine("Count= "+count);
Console.WriteLine("Hello, World!");

Product p = new Product();
p.Id = 1;
p.Title = "Sapiens";
p.Description = "A brief history of humankind";
p.Price = 10.99m;

Console.WriteLine($"Product: {p.Id}, {p.Title}, {p.Description}, {p.Price}");

Product p2 = new Product();
p2.Id = 1;
p2.Title = "Rich Dad Poor Dad";
p2.Description = "A book on personal finance";
p2.Price = 6.99m;

Console.WriteLine($"Product: {p2.Id}, {p2.Title}, {p2.Description}, {p2.Price}");