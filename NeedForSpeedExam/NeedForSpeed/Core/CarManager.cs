using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CarManager
{

    private List<Car> cars;
    private List<Race> races;
    private Garage garage;
    public CarManager()
    {
        this.races = new List<Race>();
        this.cars = new List<Car>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {


        Car car;
        switch (type)
        {
            case "Performance":
                 car = new PerformanceCar(id,brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "Show":
                 car = new ShowCar(id,brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            default:
                throw new InvalidOperationException();
        }
        this.cars.Add(car);
    }

    public string Check(int id)
    {
        var checkCar = cars.FirstOrDefault(c => c.Id == id);
        if (checkCar != null)
        {
            return checkCar.ToString();
        }
        return "Invalid id";
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                races.Add(new CasualRace(id,length, route, prizePool));
                break;
            case "Drag":
                races.Add(new DragRace(id,length, route, prizePool));
                break;
            case "Drift":
                races.Add(new DriftRace(id,length, route, prizePool));
                break;
            default:
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        var participant = cars.FirstOrDefault(c => c.Id == carId);
        var race = races.FirstOrDefault(r => r.Id == raceId);
        participant.IsCarRacing = true;
        if (participant.IsCarParked == false)
        {    
                race.Participants.Add(participant);   
        }
        
    }

    public string Start(int id)
    {
        var race = races.FirstOrDefault(r => r.Id == id);
        if (race.IsOpen)
        {

        }
        return race.ToString();
    }

   public void Park(int id)
    {
        var carToPark = cars.FirstOrDefault(c => c.Id == id);
        if (carToPark.IsCarRacing == false)
        {
            garage.ParkedCars.Add(carToPark);
            carToPark.IsCarParked = true;
        }
    }

    public	void Unpark(int id)
    {
        var carToPark = cars.FirstOrDefault(c => c.Id == id);
        if (carToPark.IsCarParked == true)
        {
            garage.ParkedCars.Remove(carToPark);
            carToPark.IsCarParked = false;
        }

    }

   public void Tune(int tuneIndex, string addOn)
    {
        ShowCar showCar;
        PerformanceCar performanceCar;
        if (garage.ParkedCars.Count > 0)
        {
            foreach (var car in garage.ParkedCars)
            {
                if (car is ShowCar)
                {
                    showCar = (ShowCar)car;
                    showCar.Stars += tuneIndex;
                    showCar.Horsepower += tuneIndex;
                    showCar.Suspension += tuneIndex / 2;
                }
                else if (car is PerformanceCar)
                {
                    performanceCar = (PerformanceCar)car;
                    performanceCar.AddOns.Add(addOn);
                    performanceCar.Horsepower += tuneIndex;
                    performanceCar.Suspension += tuneIndex / 2;
                }
            }
            
        }
    }
}

