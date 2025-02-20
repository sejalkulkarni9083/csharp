namespace Catalog;

public class ProductManager{
    public bool Insert(Product prd){
        return false;
    } 
   public bool Update(Product prd){
        return true;
    }

public bool Delete(int ProductId){
        return false;
    }
    public List<Product> GetAll(){
    
    List<Product> allProducts = new List<Product>();

    allProducts.Add(new Product{
        Id=1, 
        Title="Rose", 
        Description=" valentine flower", 
        Quantity=6000, 
        Price=12.0
        });

    allProducts.Add(new Product{
        Id=2, 
        Title="Tulip", 
        Description="Spring flower", 
        Quantity=3000, 
        Price=8.0
        });

        allProducts.Add(new Product{
        Id=3, 
        Title="Sunflower", 
        Description=" Summer flower", 
        Quantity=1500, 
        Price=10.0
        });
        return allProducts;
}

public Product GetProductById(int ProductId){
    return new Product{
        Id=ProductId, 
        Title="Rose", 
        Description=" valentine flower", 
        Quantity=6000, 
        Price=12.0
        };
    }
}