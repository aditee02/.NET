using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssigment1
{
    public class Customer
    {
        public int CustomerID { get; set; } // Unique identifier for a customer
        public string FirstName { get; set; } // First name of the customer
        public string LastName { get; set; } // Last name of the customer
        public string Country { get; set; } // Country where the customer is locate
    }


    // This is the Order class, representing an order placed by a customer.
    public class Order
    {
        public int OrderID { get; set; } // Unique identifier for an order
        public int CustomerID { get; set; } // Identifier for the customer who placed the order
        public DateTime OrderDate { get; set; } // Date on which the order was placed
        public DateTime? ShippedDate { get; set; } // Date on which the order was shipped, nullable
    }


    // This is the Product class, representing a product that may be ordered.
    public class Product
    {
        public int ProductID { get; set; } // Unique identifier for a product
        public string ProductName { get; set; } // Name of the product
        public decimal UnitPrice { get; set; } // Price of a single unit of the product
    }

    // This is the OrderDetail class, representing a line item in an order.
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Unique identifier for an order detail
        public int OrderID { get; set; } // Identifier for the order to which the detail belongs
        public int ProductID { get; set; } // Identifier for the product in the order detail
        public int Quantity { get; set; } // Number of units of the product ordered
        public decimal Discount { get; set; } // Discount applied to the product in the order detail
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, FirstName = "Seema", LastName = "Joshi", Country = "India" },
                new Customer { CustomerID = 2, FirstName = "Tailore", LastName = "Swift", Country = "USA" },
                new Customer { CustomerID = 3, FirstName = "Ram", LastName = "Charan", Country = "India" },
                new Customer { CustomerID = 4, FirstName = "Alexander", LastName = "Dimitri", Country = "France" },
                new Customer { CustomerID = 5, FirstName = "kamala", LastName = "Harris", Country = "USA" },
            };

            var sorted = from cust in customers orderby cust.LastName select cust;
            Console.WriteLine("--------------------");
            Console.WriteLine("a list of all customers in alphabetical order by last name : ");
            foreach(var cust in sorted) {
                Console.WriteLine(cust.CustomerID+","+cust.FirstName+","+cust.LastName+","+cust.Country);
            }

            List<Product> products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Laptop", UnitPrice = 1200.50m },
                new Product { ProductID = 2, ProductName = "Smartphone", UnitPrice = 799.99m },
                new Product { ProductID = 3, ProductName = "Tablet", UnitPrice = 499.99m },
                new Product { ProductID = 4, ProductName = "Desktop", UnitPrice = 1500.00m },
                new Product { ProductID = 5, ProductName = "Monitor", UnitPrice = 299.99m },
                new Product { ProductID = 6, ProductName = "Keyboard", UnitPrice = 49.99m },
                new Product { ProductID = 7, ProductName = "Mouse", UnitPrice = 29.99m },
                new Product { ProductID = 8, ProductName = "Headphones", UnitPrice = 99.99m },
                new Product { ProductID = 9, ProductName = "Speakers", UnitPrice = 149.99m },
                new Product { ProductID = 10, ProductName = "Printer", UnitPrice = 199.99m },
                new Product { ProductID = 11, ProductName = "External Hard Drive", UnitPrice = 129.99m },
                new Product { ProductID = 12, ProductName = "Webcam", UnitPrice = 79.99m },
                new Product { ProductID = 13, ProductName = "Router", UnitPrice = 89.99m },
                new Product { ProductID = 14, ProductName = "Ethernet Cable", UnitPrice = 9.99m },
                new Product { ProductID = 15, ProductName = "Wireless Mouse", UnitPrice = 39.99m },
                
            };
            Console.WriteLine("--------------------");
            Console.WriteLine(" list of all products in order of unit price, from highest to lowest.");

            IOrderedEnumerable<Product> sortedProducts = products.OrderByDescending
                (pro => pro.UnitPrice);

            foreach(Product item in sortedProducts) { 
                Console.WriteLine(item.ProductID+","+item.ProductName+","+item.UnitPrice);
            }
            Console.WriteLine("--------------------");
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = DateTime.Parse("2021-10-10"), ShippedDate = DateTime.Parse("2024-03-12") },
                new Order { OrderID = 2, CustomerID = 2, OrderDate = DateTime.Parse("2024-03-11"), ShippedDate = DateTime.Parse("2021-10-10") },
                new Order { OrderID = 3, CustomerID = 3, OrderDate = DateTime.Parse("2024-03-12"), ShippedDate = DateTime.Parse("2024-03-15") },
                new Order { OrderID = 4, CustomerID = 4, OrderDate = DateTime.Parse("2021-03-11"), ShippedDate = DateTime.Parse("2024-03-16") },
                new Order { OrderID = 5, CustomerID = 5, OrderDate = DateTime.Parse("2024-03-14"), ShippedDate = DateTime.Parse("2024-03-17") },
            };
           
            Console.WriteLine("--------------------");
            var order3 = orders.Where(or1 =>  or1.ShippedDate.Value.Year == 2021 && or1.ShippedDate.Value.Month == 10);

            Console.WriteLine("a list of all orders that were shipped in October 2021.");

            foreach(Order item in order3)
            {
                Console.WriteLine(item.OrderID+","+ item.CustomerID+","+ item.OrderDate+","+ item.ShippedDate);
            }
            Console.WriteLine("--------------------");


            Console.WriteLine("a list of all orders that were shipped to customers in the USA.");

            var customerOrders = from customer in customers
                                 join order in orders on customer.CustomerID equals order.CustomerID
                                 where customer.Country == "USA" 
                                 select new
                                 {
                                     customer.FirstName,
                                     customer.LastName,
                                     customer.Country,
                                     order.OrderID,
                                     order.OrderDate,
                                     order.ShippedDate
                                 };
            foreach(var customer in customerOrders)
            {
                Console.WriteLine(customer.FirstName+" "+customer.LastName+","+customer.Country + ","+customer.OrderDate+","+customer.ShippedDate);
             
            }


            Console.WriteLine("--------------------");
            List<OrderDetail> orderDetails = new List<OrderDetail>
{
    new OrderDetail { OrderDetailID = 1, OrderID = 1, ProductID = 1, Quantity = 5, Discount = 0.1m },
    new OrderDetail { OrderDetailID = 2, OrderID = 1, ProductID = 2, Quantity = 3, Discount = 0 },
    new OrderDetail { OrderDetailID = 3, OrderID = 2, ProductID = 3, Quantity = 2, Discount = 0.2m },
    new OrderDetail { OrderDetailID = 4, OrderID = 2, ProductID = 7, Quantity = 4, Discount = 0 },
    new OrderDetail { OrderDetailID = 5, OrderID = 3, ProductID = 4, Quantity = 1, Discount = 0 },
    new OrderDetail { OrderDetailID = 6, OrderID = 3, ProductID = 5, Quantity = 2, Discount = 0.15m },
    new OrderDetail { OrderDetailID = 7, OrderID = 4, ProductID = 9, Quantity = 6, Discount = 0.1m },
    new OrderDetail { OrderDetailID = 8, OrderID = 4, ProductID = 3, Quantity = 3, Discount = 0 },
    new OrderDetail { OrderDetailID = 9, OrderID = 5, ProductID = 13, Quantity = 4, Discount = 0.2m },
    new OrderDetail { OrderDetailID = 10, OrderID = 5, ProductID = 11, Quantity = 2, Discount = 0 }
};

            Console.WriteLine(" a list of all products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product.");


            var proOrder = from orderdetail in orderDetails
                           join product in products on orderdetail.ProductID equals product.ProductID
                           where orderdetail.Quantity >= 1
                           select new
                           {
                               orderdetail.OrderID,
                               orderdetail.ProductID,
                               orderdetail.Quantity,
                               orderdetail.Discount,
                               orderdetail.OrderDetailID,
                               product.UnitPrice
                           };

            foreach(var op in proOrder)
            {
                Console.WriteLine(op.ProductID + ":" + op.Quantity + (op.Quantity * op.UnitPrice));
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("a list of the top 5 customers by the total amount of money they have spent, along with the number of orders they have " +
                "placed and the average order amount.");


            var Custoo = from customer in customers
                         join order in orders on customer.CustomerID equals order.CustomerID
                         join orderDetail in orderDetails on order.OrderID equals orderDetail.OrderID
                         join product in products on orderDetail.ProductID equals product.ProductID
                         select new
                         {

                             orderDetail.Quantity,
                             product.UnitPrice,
                             customer.CustomerID
                         };

            foreach(var op in Custoo)
            {
               // int numberOfOrdersForCustomer = orders.Count(order => order.CustomerID);
                Console.WriteLine("Total Amount Spent : "+(op.Quantity*op.UnitPrice)+","+"Number of orders");
            }

            Console.WriteLine("--------------------");

            Console.ReadKey();


        }
    }
}
