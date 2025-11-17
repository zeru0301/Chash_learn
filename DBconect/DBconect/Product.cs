using System;
public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"商品ID:{Id}");
        Console.WriteLine($"商品名: {Name}");
        Console.WriteLine($"商品の値段:{Price} 円");
    }
}