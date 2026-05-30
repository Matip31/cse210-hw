public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;
    public Product(string name,int id,int price,int quantity)
    {
        _name=name;
        _productId=id;
        _price=price;
        _quantity=quantity;
    }
    public int CalcTotalCost()
    {
        return _price*_quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _productId;
    }
}