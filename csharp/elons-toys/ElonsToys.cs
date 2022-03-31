using System;

class RemoteControlCar
{
    public int battery = 100;
    public int distance = 0;



    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        if (distance <= 2000)
        {
            return ("Driven " + distance + " meters");
        }
        else
        {
            return ("Driven 2000 meters");
        }
    }

    public string BatteryDisplay()
    {
        if (battery >= 0)
        {
            return ("Battery at " + battery + "%");
        }
        else
        {
            return ("Battery empty");
        }
    }

    public void Drive()
    {
        distance += 20;
        battery -= 1;
    }
}
