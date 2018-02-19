using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var persons = new List<Person>();

        while (line != "End")
        {
            var tokens = line.Split();

            var name = tokens[0];
            var person = persons.FirstOrDefault(p => p.Name == name);
            if (person == null)
            {
                person = new Person(name);
                persons.Add(person);
            }
            

            switch (tokens[1])
            {
                case "company":
                    var compName = tokens[2];
                    var position = tokens[3];
                    var salary = decimal.Parse(tokens[4]);
                    person.Company = new Company(compName, position, salary);
                    break;
                case "pokemon":
                    var pokName = tokens[2];
                    var pokElement = tokens[3];
                    var pokemon = new Pokemon(pokName, pokElement);
                    person.Pokemons.Add(pokemon);
                    break;
                case "car":
                    var carName = tokens[2];
                    var carSpeed = int.Parse(tokens[3]);
                    person.Car = new Car(carName, carSpeed);
                    break;
                case "children":
                    var childName = tokens[2];
                    var childBirthday = tokens[3];
                    person.Childrens.Add(new FamilyMember(childName, childBirthday));
                    break;
                case "parents":
                    var parentName = tokens[2];
                    var parentBirthday = tokens[3];
                    person.Parents.Add(new FamilyMember(parentName, parentBirthday));
                    break;
                default:
                    break;
            }
            persons.Add(person);
            line = Console.ReadLine();
        }
        line = Console.ReadLine();
        var per = persons.FirstOrDefault(p => p.Name == line);
        if (per != null)
        {
            Console.Write(per.ToString());
        }
        
        
    }
}

