using System.Collections.Generic;
namespace ShoppingCart;

public class Cart{
    private List<Item> items=new List<Item>();
    public List<Item> Items{
        get{return this.items;}
    }
    public void AddToCart(Item item){
        this.items.Add(item);
    }
    public void RemoveFromCart(Item item){
        this.items.Remove(item);
    }

}