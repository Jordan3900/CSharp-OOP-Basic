//using System;
//using System.Collections.Generic;
//using System.Text;


//public class Car
//{
//    private string model;
//    private Engine engine;
//    private Cargo cargo;
//    private Tyre[] tires;

//    public Car(string model, Engine engine, Cargo cargo, Tyre[] tires)
//    {
//        this.model = model;
//        this.engine = engine;
//        this.cargo = cargo;
//        this.tires = tires;
//    }

//    public string Model => this.model;
//    public Engine Engine => this.engine;
//    public Cargo Cargo => this.Cargo;
//    public Tyre[] Tires => this.tires;
//}
public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }


    public string Model => this.model;
    public Engine Engine => this.engine;
    public Cargo Cargo => this.cargo;
    public Tire[] Tires => this.tires;
}

