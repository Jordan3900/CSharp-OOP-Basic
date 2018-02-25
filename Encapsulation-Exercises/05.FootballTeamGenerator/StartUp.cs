using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        List<Team> teams = new List<Team>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(';',StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 2)
            {
                continue;
            }

            try
            {
                var command = tokens[0];
                var teamName = tokens[1];

                if (command == "Team")
                {
                    teams.Add(new Team (teamName));
                    continue;
                }

                var team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        team.AddPlayer(new Player(tokens[2], tokens.Skip(3).Select(int.Parse).ToArray()));
                        break;
                    case "Remove":
                        team.RemovePlayer(tokens[2]);
                        break;
                    case "Rating":
                        Console.WriteLine($"{team.Name} - {team.GetRating()}");
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

