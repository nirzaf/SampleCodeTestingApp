using System.Globalization;

using static System.Console;
using static System.DateTime;

namespace SampleCodeTestingApp;

public static class Converters
{
    public static DateTime ConvertStringToDate(string date)
    {
        try
        {
            DateTime dt = ParseExact(date, "yyyy-mm-dd", CultureInfo.InvariantCulture);
            return dt;
        }
        catch (Exception exception)
        {
            WriteLine(exception);
            throw;
        }
    }
}