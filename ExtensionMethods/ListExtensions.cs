namespace ExtensionMethods;

public static class ListExtensions
{
    public static List<int> FilterList(this List<int> list, int minValue)
    {
        List<int> filteredList = new List<int>();
        foreach (var item in list)
        {
            if (item >= minValue)
            {
                filteredList.Add(item);
            }
        }
        return filteredList;
    }
    public static List<string> ToUpper(this List<string> list)
    {
        List<string> upperList = new List<string>();
        foreach (var item in list)
        {
            upperList.Add(item.ToUpper());
        }
        return upperList;
    }

    public static List<string> ToLower(this List<string> list)
    {
        List<string> lowerList = new List<string>();
        foreach (var item in list)
        {
            lowerList.Add(item.ToLower());
        }
        return lowerList;
    }

    public static string LonguestString(this List<string> list)
    {

        string longestString = list[0];
        foreach (var item in list)
        {
            if (item.Length > longestString.Length)
            {
                longestString = item;
            }
        }
        return longestString;
    }

    public static string ShortestString(this List<string> list)
    {
        string shortestString;
        if (list.Count > 0)
        {
            shortestString = list[0];
        }
        else
        {
            return string.Empty;
        }
        foreach (var item in list)
        {
            if (item.Length < shortestString.Length)
            {
                shortestString = item;
            }
        }
        return shortestString;
    }

    public static int MaxValue(this List<int> list)
    {
        int maxValue;
        if (list.Count > 0)
        {
            maxValue = list[0];
        }
        else
        {
            return 0;
        }
        foreach (var item in list)
        {
            if (item > maxValue)
            {
                maxValue = item;
            }
        }
        return maxValue;
    }

    public static int MinValue(this List<int> list)
    {

        int minValue;
        if (list.Count > 0)
        {
            minValue = list[0];
        }
        else
        {
            return 0;
        }
        foreach (var item in list)
        {
            if (item < minValue)
            {
                minValue = item;
            }
        }
        return minValue;
    }

    public static int ListTotal(this List<int> list)
    {
        int total;
        if (list.Count > 0)
        {
            total = 0;
        }
        else
        {
            return 0;
        }
        foreach (var item in list)
        {
            total += item;
        }
        return total;
    }

    public static double ListAverage(this List<int> list)
    {
        int total = list.ListTotal();
        return (double)total / list.Count;
    }

    public static T MaxValue2<T>(this List<T> list) where T : IComparable<T>
    {
        if (list.Count == 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        T maxValue = list[0];
        foreach (var item in list)
        {
            if (item.CompareTo(maxValue) == 1)
            {
                maxValue = item;
            }
        }
        return maxValue;
    }


}
