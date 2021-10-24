using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        var ProductionRatePerHour= 221;
        var scsRate = 0.0;

        if (speed <= 4){
            return (speed*ProductionRatePerHour);
        }
        else if (speed <= 8){
            scsRate = 0.9;
            return (speed * scsRate * ProductionRatePerHour);
        }
        else if (speed <= 9)
        {
            scsRate = 0.8;
            return (speed * scsRate * ProductionRatePerHour);
        }
        else if (speed <= 10)
        {
            scsRate = 0.77;
            return (speed * scsRate * ProductionRatePerHour);
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed)/60;

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
