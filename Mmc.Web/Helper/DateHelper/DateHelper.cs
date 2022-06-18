namespace Mechi.Backend.Helper.DateHelper;

public static class DateHelper
{
    public static DateOnly GetDateOnly()
    {
        return DateOnly.FromDateTime(DateTime.Now);
    }

    public static TimeOnly GetTimeOnly()
    {
        return TimeOnly.FromDateTime(DateTime.Now);
    }

    public static DateTime GetDateTime(this DateOnly argPostedDate, TimeOnly argPostedTime)
    {
        return argPostedDate.ToDateTime(argPostedTime);
    }
}