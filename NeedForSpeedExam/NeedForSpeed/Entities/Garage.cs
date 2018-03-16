using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        parkedCars = new List<Car>();
    }

    public List<Car> ParkedCars
    {
        get { return parkedCars; }
        set { parkedCars = value; }
    }


}

