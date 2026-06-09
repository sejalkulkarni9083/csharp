namespace Notification
{

    
    public class Program{

    public delegate void OrderOperation(int orderId);


    public static void ProcessOrder(int orderId)
    {
        Console.WriteLine("Order is processed");
    }

    public static void CancelOrder(int orderId)
    {
        Console.WriteLine("Order is canceled");
    }

     public static void ShipProduct(int orderId)
    {
        Console.WriteLine("product is deliverd to customer end");
    }

    public static void Main(string [] args){



        OrderOperation o1=new OrderOperation(ProcessOrder); 
        OrderOperation o2=new OrderOperation(CancelOrder);  
        OrderOperation o3=new OrderOperation(ShipProduct); 
        
        o3.Invoke(98);  



        OrderOperation masterO=null;


        masterO+=o1;
        masterO+=o2;
        masterO+=o3;
        
        masterO(876);
        Console.WriteLine("After detachment");

        masterO-=o3;
        masterO(876);

    }
    }
}