public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        var gigasecond = TimeSpan.FromSeconds(1e9);
        return moment.Add(gigasecond);
    }
}