public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int month;
    private int year;
    
    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var days = new List<DateTime>();
        var daysInMonth = DateTime.DaysInMonth(year, month);

        for (int day = 1; day <= daysInMonth; day++)
        {
            var date = new DateTime(year, month, day);
            if (date.DayOfWeek == dayOfWeek)
                days.Add(date);
        }

        switch (schedule)
        {
            case Schedule.First:
                return days[0];
            case Schedule.Second:
                return days[1];
            case Schedule.Third:
                return days[2];
            case Schedule.Fourth:
                return days[3];
            case Schedule.Last:
                return days[days.Count - 1];
            case Schedule.Teenth:
                return days.First(d => d.Day >= 13 && d.Day <= 19);
            default:
                throw new ArgumentException("Invalid schedule");
        }
    }
}