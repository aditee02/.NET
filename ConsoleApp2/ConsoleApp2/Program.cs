
class Sample
{

    static void Main()
    {
        Product product1, product2, product3;

        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        System.Console.WriteLine("Product1 : ");
        System.Console.WriteLine("Product ID : " + product1.productID);
        System.Console.WriteLine("Product Name : " + product1.productName);
        System.Console.WriteLine("Product Cost : " + product1.cost);
        System.Console.WriteLine("Quantity in Stock : " + product1.quantityInStock);
        System.Console.WriteLine("Date of Purchase : " + product1.dataOfPurchase);
        System.Console.WriteLine();

        System.Console.WriteLine("Product2 : ");
        System.Console.WriteLine("Product ID : " + product2.productID);
        System.Console.WriteLine("Product Name : " + product2.productName);
        System.Console.WriteLine("Product Cost : " + product2.cost);
        System.Console.WriteLine("Quantity in Stock : " + product2.quantityInStock);
        System.Console.WriteLine("Date of Purchase : " + product2.dataOfPurchase);
        System.Console.WriteLine();
        System.Console.WriteLine("Product3 : ");
        System.Console.WriteLine("Product ID : " + product3.productID);
        System.Console.WriteLine("Product Name : " + product3.productName);
        System.Console.WriteLine("Product Cost : " + product3.cost);
        System.Console.WriteLine("Quantity in Stock : " + product3.quantityInStock);
        System.Console.WriteLine("Date of Purchase : " + product3.dataOfPurchase);

        double highestCost;
        if(product1.cost > product2.cost) {
            highestCost = product1.cost;
        }
        else
        {
            highestCost = product2.cost;
        }

        if (highestCost < product3.cost)
        {
            highestCost = product3.cost;
        }

        System.Console.WriteLine("HigestCost : " + highestCost);
        System.Console.ReadLine();
    }
}