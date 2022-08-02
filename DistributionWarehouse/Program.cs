using DistributionWarehouse;
public class Hello
{

    public static void Main(string[] args)
    {
        Product p = new Product()
        {
            Name = "ceva",
            Unit = "kg",
            Price = 12.5F
        };
        Console.WriteLine(p.ToString());
     

    }
}
