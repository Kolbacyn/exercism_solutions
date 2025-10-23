class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay.Length > 0 ? birdsPerDay[birdsPerDay.Length - 1] : 0;

    public void IncrementTodaysCount()
    {
        if (birdsPerDay.Length > 0)
        {
            birdsPerDay[birdsPerDay.Length - 1]++;
        }
        
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < 7; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalBirds += birdsPerDay[i];
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
