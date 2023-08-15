namespace Calculater.Classes;
public class Program
{
    static void Main()
    {
        var calculatR = new CalculatR();
        string yesOrNo = "";
        do
        {
            calculatR.Calculate();
            ReportR.ReportProgress("Do want to continue? [y/n]");
            yesOrNo = Console.ReadLine();
        } while (yesOrNo == "y");

        ReportR.ShowGratitude();
        calculatR.ShowMultiplicationTable();

    }
}