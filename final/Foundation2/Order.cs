using System.Data.Common;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public List<Product> GetProducts()
    {
        return this.products;
    }

    public Customer GetCustomer()
    {
        return this.customer;
    }

    public void SetCustomer(Customer customer)
    {
        this.customer = customer;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in this.products)
        {
            totalCost += product.GetTotalPrice();   
        }
        //totalCost += this.customer.LivesInUSA() ? 5 : 35;
        if (this.customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach(var product in this.products)
        {
            label += $"{product.GetName()}(Product ID:{product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{this.customer.GetName()}\n{this.customer.GetAddress()}";
    }
}