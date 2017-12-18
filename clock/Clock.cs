using System;

public struct Clock
{
    int hours, minutes;

    public Clock(int hours, int minutes)
    {
        this.hours = hours % 24;

        // Check for minute overflow
        if (minutes < 60)
        {
            this.minutes = minutes;
        }
        else
        {
            hours += minutes / 60;
            this.minutes = minutes % 60;
        }
    }

    public int Hours
    {
        get
        {
            return hours;
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        int hoursAdded = (minutes + minutesToAdd) / 60;
        hours = (hours + hoursAdded) % 24;
        minutes = (minutes + minutesToAdd) % 60;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}