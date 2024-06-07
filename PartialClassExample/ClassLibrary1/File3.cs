namespace warehouse {
    public partial class Product
    {
        //public method
        public void GetTax()
        {
            double tax = Cost * 10 / 100;
            System.Console.WriteLine("Tax : " + tax);

        }

    }
}