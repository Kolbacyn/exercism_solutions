using System;
using System.Globalization;
using System.Runtime.InteropServices;


public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) =>
        dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime localDateTime = DateTime.Parse(appointmentDateDescription);
        string timeZoneId = GetTimeZoneId(location);
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTime unspecifiedLocal = DateTime.SpecifyKind(localDateTime, DateTimeKind.Unspecified);
        DateTime utcDateTime = TimeZoneInfo.ConvertTimeToUtc(unspecifiedLocal, timeZone);

        return utcDateTime;
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
            AlertLevel.Early => appointment - TimeSpan.FromDays(1),
            AlertLevel.Standard => appointment - TimeSpan.FromMinutes(105),
            AlertLevel.Late => appointment - TimeSpan.FromMinutes(30),
            _ => throw new ArgumentException("Unknown alert level")
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        string timeZoneId = GetTimeZoneId(location);
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTime dateTimeMinusWeek = dt.AddDays(-7);

        bool dstNow = timeZone.IsDaylightSavingTime(dt);
        bool dstBefore = timeZone.IsDaylightSavingTime(dateTimeMinusWeek);

        return dstNow != dstBefore;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = GetCultureInfo(location);
        if (DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out DateTime parsedDate))
        {
            return parsedDate;
        }
        return DateTime.MinValue;
    }

    private static string GetTimeZoneId(Location location)
    {
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        return location switch
        {
            Location.NewYork => isWindows ? "Eastern Standard Time" : "America/New_York",
            Location.London => isWindows ? "GMT Standard Time" : "Europe/London",
            Location.Paris => isWindows ? "W. Europe Standard Time" : "Europe/Paris",
            _ => throw new ArgumentException("Unknown location")
        };
    }

    private static CultureInfo GetCultureInfo(Location location)
    {
        return location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => throw new ArgumentException("Unknown location")
        };
    }
}
