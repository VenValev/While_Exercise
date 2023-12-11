double sum = 0;
string s = "";
while (true)
{
    s = Console.ReadLine();
    if (s == "NoMoreMoney")
    {
        Console.WriteLine($"Total: {sum:f2}");
        break;
    }
    else
    {
        if (double.Parse(s) < 0)
        {
            Console.WriteLine($"Invalid operation!");
            Console.WriteLine($"Total: {sum:f2}");
            break;
        }
        else
        {
            Console.WriteLine($"Increase: {double.Parse(s):f2}");
            sum = sum + double.Parse(s);
        }

    }
}