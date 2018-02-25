using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private string birthday;
    private List<Person> children;
    private List<Person> parents;

    public Person()
    {
       
        this.children = new List<Person>();
        this.parents = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public List<Person> Childrens
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { this.Parents = value; }
    }


}