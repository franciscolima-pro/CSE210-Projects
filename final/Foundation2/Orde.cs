using System.ComponentModel;

class Order
{
    private List<Product> _products;
    Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void addProduct(Product product)
    {
        _products.Add(product);
    }
    public int getTotalCost()
    {
        int total = 0;
        foreach(Product product in _products)
        {
            total += product.getTotalCost();
        }
        if(_customer.ifInUsa())
        {
            total += 5;
        }
        else{
            total += 35;
        }
        return total;
    }
    public string getPackingLabel()
    {
        string packingLabel = "Packing List: ";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.getName()}, ID: {product.getProductID()}" + "\n";
        }
        return packingLabel;
    }
    public string getShippingLabel()
    {
        string shippingLabel = "Shipping to: ";
        shippingLabel += _customer.getName() + "\n";
        shippingLabel += _customer.getAddress() + "\n";
        return shippingLabel; 
    }
}

