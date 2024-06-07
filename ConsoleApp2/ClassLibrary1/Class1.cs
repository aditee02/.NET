
public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dataOfPurchase;

    //constructor
    public Product()
    {
        dataOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}
