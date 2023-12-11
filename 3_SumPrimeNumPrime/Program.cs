int sumSimp = 0;
int sumNum = 0;
while (true)
{
    string s = Console.ReadLine();
    if (s == "stop")
    {
        break;
    }
    bool b = false;

    int num = int.Parse(s);
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            b = true;
            break;
        }
    }
    if (num < 0)
    {
        Console.WriteLine($"Number is negative.");
    }
    else if (b)
    {
        sumNum += num;
    }
    else
    {
        sumSimp += num;
    }
}
Console.WriteLine($"Sum of all prime numbers is: {sumSimp}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNum}");