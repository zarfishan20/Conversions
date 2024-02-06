string[] values = { "12.3", "45", "ABC", "11", "DEF" };

double totalValue = 0;
string message = " ";

foreach (string value in values)

{
    if (double.TryParse(value, out double numericValue))

    {
        totalValue += numericValue;
        Console.WriteLine("Total:" + totalValue);
    }

    else
    {
        message += value;
        Console.WriteLine("Message: " + message);
    }
}
