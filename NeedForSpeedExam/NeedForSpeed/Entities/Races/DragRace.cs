using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DragRace : Race
{
    public DragRace(int id, int length, string route, int prizePool) : base(id, length, route, prizePool)
    {
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        var counter = 1;
        if (Participants.Count > 0)
        {
            builder.AppendLine($"{Route} - {Length}");
            foreach (var participant in Participants.OrderByDescending(p => p.EnginePerformance).Take(3))
            {

                switch (counter)
                { 
                    case 1:
                        builder.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.EnginePerformance}PP - ${PrizePool * 0.5}");
                        break;
                    case 2:
                        builder.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.EnginePerformance}PP - ${PrizePool * 0.3}");
                        break;
                    case 3:
                        builder.AppendLine($"{counter}. {participant.Brand} {participant.Model} {participant.EnginePerformance}PP - ${PrizePool * 0.2}");
                        break;
                    default:
                        break;
                }
                counter++;
            }
            foreach (var item in Participants)
            {
                item.IsCarRacing = false;
            }
        }
        else
        {
            builder.AppendLine("Cannot start the race with zero participants");
        }
        this.IsOpen = false;
        return builder.ToString();
    }
}

