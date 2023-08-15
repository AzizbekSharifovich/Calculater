namespace Calculater.Classes;
public class CalculatR
{
    public void Calculate()
    {
        string firstUserValue = ValueManipulatR.GetUserValueByMessage("Enter values.\n First number:");
        string operation = ValueManipulatR.GetUserValueByMessage("Operation [+, -, *, /, %]:");
        string secondUserValue = ValueManipulatR.GetUserValueByMessage("\nSecond number:");

        ReportR.ReportProgress("Converting values in progress...");
        decimal firstNumber = ValueManipulatR.ConvertUserValueToDecimal(firstUserValue);
        decimal secondNumber = ValueManipulatR.ConvertUserValueToDecimal(secondUserValue);

        ReportR.ReportProgress("Converting values  in progress...");

        string template = $"{firstNumber} {operation} {secondNumber}";

        decimal result = operation switch
        {
            "+" => Sum(firstNumber, secondNumber),
            "-" => Substract(firstNumber, secondNumber),
            "*" => Multiply(firstNumber, secondNumber),
            "/" => Divide(firstNumber, secondNumber),
            "%" => CalculateRemainder(firstNumber, secondNumber),
            _ => 0
        };

        ReportR.ReportProgress($"{template} {result}");
    }
    public void ShowMultiplicationTable()
    {
        Console.WriteLine("Here is the multiplication table for your reference.");
        for (int outerIteration = 2; outerIteration < 10; outerIteration++)
        {
            Console.WriteLine("===================");
            for (int iteration = 1; iteration <= 10; iteration++)
            {
                Console.WriteLine($"{outerIteration} * {iteration} = {outerIteration * iteration}");
            }
        }
    }
    private static decimal Sum(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }
    private static decimal Sum(decimal firstNumber, decimal secondNumber, decimal thridnumber)
    {
        return firstNumber + secondNumber + thridnumber;
    }
    private static decimal Sum(params decimal[] numbers)
    {
        decimal total = 0;
        foreach (decimal number in numbers)
        {
            total += number;
        }
        return total;
    }
    private static decimal Substract(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }
    private static decimal Multiply(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber * secondNumber;
    }
    private static decimal Divide(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber / secondNumber;
    }
    private static decimal CalculateRemainder(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber % secondNumber;
    }
}

