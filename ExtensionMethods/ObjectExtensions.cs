namespace ExtensionMethods;

public static class ObjectExtensions
{
    public static string GetInformation<T>(this T value, Func<T, string> selector)
    {
        return selector(value);
    }
}