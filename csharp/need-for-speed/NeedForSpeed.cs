using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int distanceDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (battery <= 0 | battery < this.batteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += this.speed;
            battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        var car = new RemoteControlCar(50, 4);
        return car;
    }
}

class RaceTrack
{
    private float distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        float autonomy = (float)car.speed / (float)car.batteryDrain;

        if (this.distance / 100 <= autonomy)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
