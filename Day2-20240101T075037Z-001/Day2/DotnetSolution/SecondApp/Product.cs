namespace Catalog;

//POCO
//Plain Old CLR Object
public class Product{
    private int id;
    //Normal Property
    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }

    //Auto Property
     public string Title{get;set;}

    /*private string title;
    public void SetTitle(string s){
        this.title=s;
    } 
    public string GetTitle(){
        return title;
    }  */

    public string? Description{get;set;}
    public float UnitPrice{get;set;}
    public string? ImagrUrl{get;set;}

    public override string ToString()
    {
        return this.Id+ " "+ this.Title + " "+ this.Description;
    }

}