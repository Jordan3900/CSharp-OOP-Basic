using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    protected Race(int id, int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        participants = new List<Car>();
        this.id = id;
        this.IsOpen = true;
    }

    public List<Car> Participants
    {
        get { return participants; }
        set { participants = value; }
    }

    public bool IsOpen { get; set; }

    public int PrizePool
    {
        get { return prizePool; }
        set { prizePool = value; }
    }

    public string Route
    {
        get { return route; }
        set { route = value; }
    }

    public int Length
    {
        get { return length; }
      protected  set { length = value; }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

