using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods;

public static class StringExtensions
{
    public static string Left(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value) || maxLength <= 0)
        {
            throw new ArgumentOutOfRangeException("MaxLength must be a positive integer.", nameof(maxLength));
        }

        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }

    public static string Right(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value) || maxLength <= 0)
        {
            throw new ArgumentOutOfRangeException("MaxLength must be a positive integer.", nameof(maxLength));
        }

        return value.Length <= maxLength ? value : value.Substring(value.Length - maxLength);
    }

    public static string Elips(this string value, int maxLength, string ellipsis = "...")
    {
        if (string.IsNullOrEmpty(ellipsis))
        {
            throw new ArgumentException("Ellipsis cannot be null or empty.", nameof(ellipsis));
        }
        if (string.IsNullOrEmpty(value) || maxLength <= 0)
        {
            throw new ArgumentOutOfRangeException("MaxLength must be a positive integer.", nameof(maxLength));
        }

        if (value.Length <= maxLength)
        {
            return value;
        }

        if (maxLength <= ellipsis.Length)
        {
            return ellipsis.Substring(0, maxLength);
        }

        return value.Substring(0, maxLength - ellipsis.Length) + ellipsis;
    }
    public static string FillLeft(this string value, int totalWidth, char paddingChar = ' ')
    {
        if (totalWidth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(totalWidth), "TotalWidth must be a positive integer.");
        }

        if (totalWidth <= value.Length)
        {
            return Left(value, totalWidth);
        }

        int paddingLength = totalWidth - value.Length;
        return new string(paddingChar, paddingLength) + value;
    }

    public static string FillRight(this string value, int totalWidth, char paddingChar = ' ')
    {
        if (totalWidth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(totalWidth), "TotalWidth must be a positive integer.");
        }

        if (totalWidth <= value.Length)
        {
            return Right(value, totalWidth);
        }

        int paddingLength = totalWidth - value.Length;
        return value + new string(paddingChar, paddingLength);
    }

    public static string CleanPath(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        return value
            .Replace(":", "")
            .Replace("\"", "")
            .Replace("/", "")
            .Replace("\\", "")
            .Replace("|", "")
            .Replace("\n", "");
    }

    public static string AddSuffix(this string value, string suffix)
    {
        if (string.IsNullOrEmpty(suffix))
        {
            throw new ArgumentException("Suffix cannot be null or empty.", nameof(suffix));
        }

        if (value.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
        {
            return value.Substring(0, value.Length - suffix.Length) + suffix;
        }

        return value + suffix;
    }

}