using System.IO;

namespace Trxlog2Html.Extensions;
public static class StringExtensions
{
    public static bool IsImage(this string value)
    {
        return value.EndsWith(".png");
    }
    public static bool IsVideo(this string value)
    {
        return value.EndsWith(".webm");
    }
    public static string GetFileName(this string value)
    {
        return value.Substring(value.LastIndexOf(Path.DirectorySeparatorChar) + 1);
    }
    
    public static string ToTitle(this string value)
    {
        return value.Substring(0,value.LastIndexOf(".")).Replace('_', ' ').Replace('-', '|');
    }
}