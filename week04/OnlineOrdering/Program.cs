using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.ProductId = "LAP1";
            product1.ProductPrice = 389.45;
            product1.Quantity = 2;

        Product product2 = new Product();
            product2.ProductName = "Sweater";
            product2.ProductId = "SWEATE2";
            product2.ProductPrice = 49.99;
            product2.Quantity = 3;
            
        Product product3 = new Product();
            product3.ProductName = "Toothbrudh";
            product3.ProductId = "DENT123";
            product3.ProductPrice = 1.99;
            product3.Quantity = 5;

        Product product4 = new Product();
            product4.ProductName = "Google Pixel 7";
            product4.ProductId = "PIX123";
            product4.ProductPrice = 544.99;
            product4.Quantity = 1;

        Product product5 = new Product();
            product5.ProductName = "Bath Towel Kit";
            product5.ProductId = "BATHSET45";
            product5.ProductPrice = 53.89;
            product5.Quantity = 2;

        Product product6 = new Product();
            product6.ProductName = "Kitchen Knife Set";
            product6.ProductId = "KITCH23";
            product6.ProductPrice = 54.99;
            product6.Quantity = 3;


        Customer customer1 = new Customer("John", "Doe", new Address("123 Main St", "Springfield", "IL", "USA"));
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");

        Customer customer2 = new Customer("Macey", "Farnes", new Address("31 Donore Rd", "Dublin", "D08 X4HV", "IRELAND"));
        Address address2 = new Address("31 Donore Rd", "Dublin", "D08 X4HV", "IRELAND");

        Customer customer3 = new Customer("John", "Doe", new Address("567 N Weaver Ave", "Boise", "ID", "USA"));
        Address address3 = new Address("567 N Weaver Ave", "Boise", "ID", "USA");
        
        Customer customer4 = new Customer("John", "Doe", new Address("231 Rue de la Colline", "Chiciutimi", "QC", "CANADA"));
        Address address4 = new Address("231 Rue de la Colline", "Chiciutimi", "QC", "CANADA");


    // First Order
        Console.WriteLine("ORDER 1");
        Order order1 = new Order(customer1, address1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.TotalCost("USA");
        order1.DisplayTotalCost();
        Console.WriteLine("--------------------------------------------------");

    // Second Order
        Console.WriteLine("ORDER 2");
        Order order2 = new Order(customer2, address2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        order2.TotalCost("IRELAND");
        order2.DisplayTotalCost();
        Console.WriteLine("--------------------------------------------------");


    // Third Order
        Console.WriteLine("ORDER 3");
        Order order3 = new Order(customer3, address3);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();
        order3.TotalCost("USA");
        order3.DisplayTotalCost();
        Console.WriteLine("--------------------------------------------------");


    // Fourth Order
        Console.WriteLine("ORDER 4");
        Order order4 = new Order(customer4, address4);
        order4.AddProduct(product5);
        order4.AddProduct(product6);

        order4.DisplayPackingLabel();
        order4.DisplayShippingLabel();
        order4.DisplayTotalCost();
        order4.TotalCost("CANADA");



        
    }
}