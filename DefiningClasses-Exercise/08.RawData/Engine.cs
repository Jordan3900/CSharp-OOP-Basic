using System;
using System.Collections.Generic;
using System.Text;


//public class Engine
//{
//    private int enginePower;
//    private int engineSpeed;

//    public Engine(int speed, int power)
//    {
//        this.enginePower = power;
//        this.engineSpeed = speed;
//    }
//    public int Power => this.enginePower;
//}
public class Engine
{
    private int speed;
    private int power;

    public Engine(int speed, int power)
    {
        this.speed = speed;
        this.power = power;
    }

    public int Power => this.power;
}

