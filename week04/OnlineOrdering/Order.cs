using System.Runtime.CompilerServices;

public class Order
{
    // constains a list of products and a customer
    private List<Product> _products;
    private Customer _customer;
    private Address _address;

    public Order(Customer customer, Address address) // constructor to initialize the order with a customer and address
    {
        _products = new List<Product>();
        _customer = customer;
        _address = address;
    }

    public double TotalCost(string country) // calculate the total price of the order
    {
        double total = 0.0;
        double shippingCost = 0.0;
    
        foreach (var product in _products)
        {
            total += product.GetPrice();
        }
    
        if (country == "US")
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }
    
        return (total * 1.06) + shippingCost;
    }
    public void DisplayTotalCost() // display the total cost of the order
    {
        string country = _address.Country.Trim().ToUpper();
        double total = TotalCost(country);
        Console.WriteLine($"Total cost: {total:C}");
    }

    public void AddProduct(Product product) // add a product to the order
    {
        _products.Add(product); 
    }

    public void DisplayPackingLabel() // display the packing label for the order
    {
        // display product name and ID for each product in the order
        foreach (var product in _products)
        {
            Console.WriteLine($"{product.ProductName} {product.ProductId}");
        }
    }

    public void DisplayShippingLabel() // display the shipping label for the order
    {
        // Use the customer field to get the name and address
        // Assuming 'customer' is a Customer object, not a string
        Console.WriteLine($"Ship to {_customer.FirstName} {_customer.LastName} at {_address.StreetAddress}, {_address.City}, {_address.StateOrProvince}, {_address.Country}");
    }
}