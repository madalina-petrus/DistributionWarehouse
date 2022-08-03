using DistributionWarehouse;
public class Hello
{

    public static void Main(string[] args)
    {


        IProduct fruit1 = new Fruit()
        {
            Name = "apple",
            Unit = "kg",
            QuantityPerUnit = 1,
            Price = 6,
            NutritionalQuality = "good"
        };

        Console.WriteLine(fruit1.toString());

        IProduct vegetable = new Vegetable()
        {
            Name = "potatoes",
            Unit = "bag",
            QuantityPerUnit = 10,
            Price = 15,
            NutritionalQuality = "good",
            Producer="PotatoSRL"
        };
        Console.WriteLine(vegetable.toString());

        Package pack = new Package()
        {
            Product = fruit1,
            EntryDate = new DateOnly(2022, 7, 12),
            ExpirationDate = new DateOnly(2022, 7, 30),
            Quantity = 10
        };

        Package pack2 = new Package()
        {
            Product = vegetable,
            EntryDate = new DateOnly(2022, 7, 12),
            ExpirationDate = new DateOnly(2022, 7, 30),
            Quantity = 20
        };
        Console.WriteLine(pack.toString());
        Console.WriteLine(pack.pricePerPackage());

        PackageRepo repo = new PackageRepo();
        repo.add(pack);
        repo.add(pack2);
        foreach(var i in repo.fruits)
        Console.WriteLine(i.toString());
        repo.delete(pack);
        foreach (var i in repo.fruits)
            Console.WriteLine(i.toString());

    }
}
