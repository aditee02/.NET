
public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dataOfPurchase;

    //constructor
    public Product()
    {
        dataOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    
    //set method
    public void setProductID(int productID) {
        this.productID = productID;
    }

    public void setproductName(string productName)
    {
        this.productName = productName;
    }

    public void setTax(double tax)
    {
        this.tax = tax;
    }


    public void setCost(double cost)
    {
        this.cost = cost;
    }
    //get method
    public int getProductID()
    {
        return productID;
    }

    public string getproductName()
    {
        return productName;
    }

    public double getTax()
    {
        return tax;
    }

    public double getCost()
    {
        return cost;
    }
}
