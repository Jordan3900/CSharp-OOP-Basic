using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var soldiers = new List<ISoldier>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            string soldierType = tokens[0];
            int id = int.Parse(tokens[1]);
            string firstName = tokens[2];
            string lastName = tokens[3];
            decimal salary = decimal.Parse(tokens[4]);

            ISoldier soldier = null; ;

            try
            {
                switch (soldierType)
                {
                    case "Private":
                        soldier = new Private(id, firstName, lastName, salary);
                        break;

                    case "LeutenantGeneral":
                        var liutenant = new LeutenantGeneral(id, firstName, lastName, salary);

                        for (int i = 5; i < tokens.Length; i++)
                        {
                            var privtId = int.Parse(tokens[i]);
                            ISoldier @private = soldiers.First(p => p.Id == privtId);
                            liutenant.AddPrivate(@private);
                        }

                        soldier = liutenant;
                        break;
                    case "Engineer":
                        string engineeringCorps = tokens[5];
                        var engineer = new Engineer(id, firstName, lastName, salary, engineeringCorps);
                        for (int i = 6; i < tokens.Length; i++)
                        {
                            string partNm = tokens[i];
                            int hoursWorked = int.Parse(tokens[++i]);

                                IRepair repair = new Repair(partNm, hoursWorked);
                                engineer.AddRepair(repair);
           
                        }

                        soldier = engineer;
                        break;
                    case "Commando":
                        string commandoCorps = tokens[5];
                        var commando = new Commando(id, firstName, lastName, salary, commandoCorps);
                        for (int i = 6; i < tokens.Length; i++)
                        {
                            string codeName = tokens[i];
                            string missionState = tokens[++i];

                            try
                            {
                                IMission mission = new Mission(codeName, missionState);
                                commando.AddMission(mission);
                            }
                            catch 
                            {
                   
                            }
                        }
                        soldier = commando;
                        break;
                    case "Spy":
                        int codeNum = (int)salary;
                        soldier = new Spy(id, firstName, lastName, codeNum);
                        break;
                    default: throw new ArgumentException("Ivalid soldier type!");

                }
                soldiers.Add(soldier);
            }
            catch (Exception e)
            {

                //Console.WriteLine(e.Message );
            }

            
        }

        foreach (var item in soldiers)
        {
            Console.WriteLine(item);
        }
    }
}

