using System;

public class Product
{
    private static int productCount = 0;

    
    public int Id { get; private set; }

        public Product()
    {
        productCount++;
        Id = productCount;
    }

    
    public static int GetProductCount()
    {
        return productCount;
    }

    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {Id}");
        Console.WriteLine($"Total Products Created: {GetProductCount()}");
    }
}

public class ElectronicProduct : Product
{
    
    public int WarrantyPeriod { get; set; }

    
    public ElectronicProduct(int warrantyPeriod)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
    }
}

public class ClothingProduct : Product
{
    
    public string Size { get; set; }

    
    public ClothingProduct(string size)
    {
        Size = size;
    }

    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}");
    }
}


public class Program
{
    public static void Main()
    {
        ElectronicProduct laptop = new ElectronicProduct(24);
        ClothingProduct shirt = new ClothingProduct("L");

        laptop.DisplayInfo();
        Console.WriteLine();
        shirt.DisplayInfo();
    }
}
