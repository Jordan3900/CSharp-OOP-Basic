using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Money = money;
        this.Name = name;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

   

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public IList<Product> GetProducts()
    {
        return this.bagOfProducts.AsReadOnly();
    }

    public void BuyProduct(Product product)
    {
        if (product.Cost > this.money)
        {
            throw new ArgumentException($"{this.name} can't afford {product.Name}");
        }
        this.money -= product.Cost;
        this.bagOfProducts.Add(product);
    }
}

