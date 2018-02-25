using System;
using System.Linq;
using System.Collections.Generic;

class ShopingSpree
{
    static void Main(string[] args)
    {
        try
        {
            var people = GetPeople();
            var products = GetProducts();

            people = BuyProducts(people, products);
            PrintBuyersWithProducts(people);
        }
        catch (ArgumentException Ex)
        {

            Console.WriteLine(Ex.Message);
        }
        
    }

    private static void PrintBuyersWithProducts(List<Person> people)
    {
        foreach (var person in people)
        {
            var boughtProducts = person.GetProducts();
            var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(p => p.Name).ToList()) : "Nothing bought";
            Console.WriteLine($"{person.Name} - {result}");
        }
    }

    private static List<Person> BuyProducts(List<Person> people, List<Product> products)
    {
        while (true)
        {
            var purchase = Console.ReadLine();
            if (purchase == "END")
            {
                break;
            }

            var purchaseTokens = purchase.Split();
            var buyer = people.First(b => b.Name == purchaseTokens[0]);
            var product = products.First(p => p.Name == purchaseTokens[1]);

            try
            {
                buyer.BuyProduct(product);
                Console.WriteLine($"{buyer.Name} bought {product.Name}");
            }
            catch (ArgumentException Ex)
            {

                Console.WriteLine(Ex.Message);
            }

        }
        return people;
    }

    private static List<Product> GetProducts()
    {
        var products = new List<Product>();
        var productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        foreach (var info in productsInfo)
        {
            var productInfo = info.Split("=",StringSplitOptions.RemoveEmptyEntries);
            products.Add(new Product(productInfo[0], decimal.Parse(productInfo[1])));
        }
        return products;
    }

    private static List<Person> GetPeople()
    {
        var people = new List<Person>();
        var personsInfo = Console.ReadLine().Split(';');
        foreach (var info in personsInfo)
        {
            var personInfo = info.Split('=');
            people.Add(new Person(personInfo[0], decimal.Parse(personInfo[1])));
        }
        return people;
    }
}

