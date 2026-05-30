public class Order
{
    private Customer _customer;
    private List<Product> _products= new List<Product>();
    public Order(Customer customer)
    {
        _customer=customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int TotalCost()
    {
        int total=0;
        foreach (Product product in _products)
            {
                total=total+product.CalcTotalCost();
            }
        if (_customer.LivesInUsa())
        {
            return total+5;
        }
        else
        {
            return total+35;
        }
    }
    public string GetPackingLabel()
    {
        string output="";
        foreach(Product p in _products)
        {
            output=$"{output} {p.GetName()}, {p.GetId()}.";
        }
        return output;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress()}";
    }
}