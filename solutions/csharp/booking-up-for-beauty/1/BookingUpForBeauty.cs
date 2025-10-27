static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (DateTime.TryParse(appointmentDateDescription, out DateTime dateTime))
            return dateTime;
        throw new ArgumentException("Invalid date format", nameof(appointmentDateDescription));
        return dateTime;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        TimeOnly timeOnly = TimeOnly.FromDateTime(appointmentDate);
        int hour = timeOnly.Hour;
        return hour >= 12 && hour < 18;
        
    }

    public static string Description(DateTime appointmentDate) =>
        $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate()
    {
        DateTime date1 = new DateTime(2019, 9, 15, 0, 0, 0);
        return date1.AddYears(6);
    }
}
