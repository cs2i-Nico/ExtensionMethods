namespace ExtensionMethods;

public static class DateTimeExtensions
{
    public static string ToIso8601(this DateTime dateTime)
    {
        return dateTime.ToString("yyyy-MM-dd");
    }
    
    public static bool IsBetween(this DateTime dateTime, DateTime startDate, DateTime endDate)
    {
        return dateTime >= startDate && dateTime <= endDate;
    }

    public static bool IsWeekDay(this DateTime dateTime)
    {
        return dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday;
    }

    public static bool IsWeekEnd(this DateTime dateTime)
    {
        return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
    }

    public static bool IsLeapYear(this DateTime dateTime)
    {
        int year = dateTime.Year;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}