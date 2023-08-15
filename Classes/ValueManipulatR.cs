namespace Calculater.Classes;
public static class ValueManipulatR
{
    public static string GetUserValueByMessage(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    public static decimal ConvertUserValueToDecimal(string userValue)
    {
        return Convert.ToDecimal(userValue);
    }
}

