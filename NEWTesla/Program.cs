int a, b, c, d, e;

a = 4; b= 5; c = 6; d = 7; e = 8;

int[] elements = new int[]{a,b,c,d,e};
foreach (var item in elements)
{
    Console.WriteLine(item);
}

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Test";
product1.Description = "HGood";

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Best";
product2.Description = "Bad";

Product[] products = new Product[] {product1, product2};

Metods metods = new Metods();
metods.Add(product2);
metods.Delete(product1);


class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Description { get; set; }
}


class Metods
{
    public void Add (Product product)
    {
        Console.WriteLine(product.Name);
    }

    public void Delete(Product product)
    {
        Console.WriteLine(product.Name + " succesfully deleted.");
    }
}