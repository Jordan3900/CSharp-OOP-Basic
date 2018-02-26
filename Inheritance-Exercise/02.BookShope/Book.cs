using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get => this.author;
        protected set
        {
            var name = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (name.Length > 1 && char.IsDigit(name[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }
    private string Title
    {
        get => this.title;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }
    public virtual decimal Price
    {
        get => this.price;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;

    }
}
