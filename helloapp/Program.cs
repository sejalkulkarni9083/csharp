// See https://aka.ms/new-console-template for more information
using Catalog;


ProductManager mgr = new ProductManager();
List<Product> retrivedProducts = mgr.GetAll();

for(int i=0;i<retrivedProducts.Count;i++){
    Console.WriteLine("Title: " + retrivedProducts[i].Title);
}
