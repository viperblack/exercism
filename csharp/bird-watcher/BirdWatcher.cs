using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1]; //In C# 8 there is a new operator for indexing: char[] arr = {'c', 'b', 'a'};   int a_last = arr[^1];   int b_second_last = arr[^2];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int number in birdsPerDay)
        {
            if (number == 0)
            {
                return true;
                break;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int counter = 0;

        foreach (int number in birdsPerDay)
        {
            if (number >= 5)
            {
                counter++;
            }
        }
        return counter;
    }
}
