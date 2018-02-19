using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var trainers = new List<Trainer>();
        while (line != "Tournament")
        {
            var tokens = line.Split();
            var trainerN = tokens[0];
            var pokemonName = tokens[1];
            var element = tokens[2];
            var health = int.Parse(tokens[3]);
            var pokemon = new Pokemon(pokemonName, element, health);
            
            var trainer = trainers.FirstOrDefault(t=>t.Name == trainerN);
            if (trainer == null)
            {
                trainer = new Trainer(trainerN);
                trainers.Add(trainer);
            }
            trainer.Pokemons.Add(pokemon);
            line = Console.ReadLine();
        }
        line = Console.ReadLine();
        while (line != "End")
        {
            trainers.Where(t => t.Pokemons.Any(p => p.Element == line)).ToList().ForEach(t => t.Badges++);

            var nonMatchTrainers = trainers.Where(t => t.Pokemons.All(p => p.Element != line));
            foreach (var nonMatchT in nonMatchTrainers)
            {
                nonMatchT.Pokemons.ForEach(p => p.Health -= 10);
                nonMatchT.Pokemons = nonMatchT.Pokemons.Where(p => p.Health > 0).ToList();
            }
            line = Console.ReadLine();
        }

        trainers.OrderByDescending(t => t.Badges).ToList().ForEach(t => Console.WriteLine(t.ToString()));
    }
}

