namespace Calculater.Classes;
public static class ReportR
{
    public static void ShowGratitude()
    {
        Console.WriteLine("Thank you for using our calculator.");

    }
    public static void ReportProgress(string message)
    {
        Console.WriteLine(message);
    }
    public static void ReportResult(string result)
    {
        Console.WriteLine(result);
    }
}

