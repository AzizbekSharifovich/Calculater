namespace Calculator;
static class Program
{
    static void Main()
    {
        string yesOrNo = "";
        do
        {
            Calculate();
            ReportProgress("Do want to continue? [y/n]");
            yesOrNo = Console.ReadLine();
        } while (yesOrNo == "y");

        ShowGratitude();
        ShowMultiplicationTable();
    }
    static void Calculate()
    {
            string firstUserValue = GetUserValueByMessage("Enter values.\n First number:");
            string operation = GetUserValueByMessage("Operation [+, -, *, /, %]:");
            string secondUserValue = GetUserValueByMessage("\nSecond number:");

            ReportProgress("Converting values in progress...");
            decimal firstNumber = ConvertUserValueToDecimal(firstUserValue);
            decimal secondNumber = ConvertUserValueToDecimal(secondUserValue);

            ReportProgress("Converting values  in progress...");

            string template = $"{firstNumber} {operation} {secondNumber}";

            decimal result = operation switch
            {
                "+" => Sum(firstNumber, secondNumber),
                "-" => Substract(firstNumber, secondNumber),
                "*" => Multiply (firstNumber, secondNumber),
                "/" => Divide (firstNumber, secondNumber),
                "%" => CalculateRemainder(firstNumber, secondNumber),
                _ => 0
            };

            Console.WriteLine($"{template} {result}");
    }
    static void ShowGratitude()
    {
         Console.WriteLine("Thank you for using our calculator.");
    }
    static void ShowMultiplicationTable()
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
    static decimal Sum(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }
    static decimal Substract(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }
    static decimal Multiply(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber * secondNumber;
    }
    static decimal Divide(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber / secondNumber;
    }
    static decimal CalculateRemainder(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber % secondNumber;
    }
    static string GetUserValueByMessage(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    static decimal ConvertUserValueToDecimal(string userValue)
    {
        return Convert.ToDecimal(userValue);
    }
    static void ReportProgress(string message)
    {
        Console.WriteLine(message);
    }
}