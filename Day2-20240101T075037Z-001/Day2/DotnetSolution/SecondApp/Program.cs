using Catalog;
using System.Collections.Generic;

List<Product> products=new List<Product>();

int count=56;
count++;
Console.WriteLine("Count "+ count);
Console.WriteLine("Hello, World!");


Console.WriteLine("Welcome to Transflower Store");
Console.WriteLine("Choose Option:");
Console.WriteLine("1:Show Catalog");
Console.WriteLine("2:Show Product Details");
Console.WriteLine("3:Show Cart");
Console.WriteLine("4:Add to Cart");
Console.WriteLine("5:Remove from Cart");
int option=int.Parse(Console.ReadLine());
switch(option){

    case 1:
    {
        Product p1=new Product();
        p1.Id=12;
        p1.Title="Gerbera";
        p1.Description="Wedding Flower";
        p1.UnitPrice=12;
        p1.ImagrUrl="gerbera.jpg";
        //Property Initializer Syntax
        Product p2=new Product{ Id=13, Title="Rose", Description="Valentine Flower",
                                UnitPrice=24, ImagrUrl="rose.jpg"};

        products.Add(p1);
        products.Add(p2);
        foreach(Product p in products){
         Console.WriteLine(p);
        }

    }
    
    break;
    
    case 2:
    break;
    
    case 3:
    break;

}