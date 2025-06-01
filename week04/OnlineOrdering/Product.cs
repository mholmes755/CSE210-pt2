public class Product
{
    private double _productPrice;
    private string _productName;
    private string _productId;
    private int _quantity;

    public double ProductPrice // getter and setter for product price
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    public string ProductName // getter and setter for product name
    {
        get { return _productName; }
        set { _productName = value; }
    }

    public string ProductId // getter and setter for product ID
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public int Quantity /// getter and setter for quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public double GetPrice()
    {
        return _productPrice * _quantity;
    }
}