public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;
    

    public Product(string name, int productId, decimal price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;

    }
    
    public string GetName() 
    {
        return this._name;
    }

    public void SetName(string name)
    {
        this._name = name;
    }

    public int GetProductId()
    {
        return this._productId;
    }

    public void SetProductId(int productId)
    {
        this._productId = productId;
    }

    public decimal GetPrice()
    {
        return this._price;
    }

    public void SetPrice(decimal price)
    {
        this._price = price;
    }

    public int GetQuantity()
    {
        return this._quantity;
    }
    public void SetQuantity(int quantity)
    {
        this._quantity = quantity;

    }

    public decimal GetTotalPrice()
    {
        return this._price * this._quantity;
    }
}

