using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var familyTree = new List<Person>();
        var input = Console.ReadLine();
        var person = new Person();
        if (IsBirthday(input))
        {
            person.Birthday = input;
            familyTree.Add(person);
        }
        else
        {
            person.Name = input;
            familyTree.Add(person);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split("-");

            if (tokens.Length > 1)
            {
                var parentToken = tokens[0];
                var childToken = tokens[1];

                var parent = CreatPerson(parentToken);
                var child = CreatPerson(childToken);
                AddParent(familyTree, parent);

                if (parent.Name != null)
                {
                    familyTree.First(p => p.Name == parent.Name).Childrens.Add(child);
                }
                else
                {
                    familyTree.First(p => p.Birthday == parent.Birthday).Childrens.Add(child);
                }
            }
            else
            {
                var token = command.Split(" ");
                var name = token[0] + " " + token[1];
                var birthday = token[2];
                var isExsits = false;

                for (int i = 0; i < familyTree.Count; i++)
                {
                    if (familyTree[i].Name == name)
                    {
                        familyTree[i].Birthday = birthday;
                        isExsits = true;
                    }
                    if (familyTree[i].Birthday == birthday)
                    {
                        familyTree[i].Name = name;
                        isExsits = true;
                    }
                    var children = new Person();
                    children.Name = name;
                    children.Birthday = birthday;
                    familyTree[i].Childrens.Add(children);
                }
                if (!isExsits)
                {
                    var member = new Person();
                    member.Name = name;
                    member.Birthday = birthday;
                    familyTree.Add(member);
                }
            }

          
        }
        Console.WriteLine();
    }

    private static void AddParent(List<Person> familyTree, Person parent)
    {
        if (parent.Name != null && familyTree.Any(p => p.Name == parent.Name) || parent.Birthday != null && familyTree.Any(p => p.Birthday == parent.Birthday) )
        {
            return;
        }
        familyTree.Add(parent);
    }

    private static Person CreatPerson(string personPar)
    {
        var person = new Person();
        if (IsBirthday(personPar))
        {
            person.Birthday = personPar;
        }
        else
        {
            person.Name = personPar;
        }
        return person;
    }

    static bool IsBirthday(string input)
    {
        return char.IsDigit(input[0]);
    }
}

