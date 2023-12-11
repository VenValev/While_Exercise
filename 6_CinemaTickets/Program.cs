double students = 0;
double kids = 0;
double standard = 0;
double totalTickets = 0;
while (true)
{
    double br1 = 0;
    string s = Console.ReadLine();
    if (s == "Finish") break;
    double seats = double.Parse(Console.ReadLine());
    for (int i = 0; i < seats; i++)
    {
        string p = Console.ReadLine();
        if (p == "End") break;
        br1++;
        if (p == "student")
        {
            students++;
        }
        else if (p == "kid")
        {
            kids++;
        }
        else if (p == "standard")
        {
            standard++;
        }
    }
    totalTickets += br1;
    Console.WriteLine($"{s} - {(br1 / seats) * 100:f2}% full.");

}
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(students / totalTickets) * 100:f2}% student tickets.");
Console.WriteLine($"{(standard / totalTickets) * 100:f2}% standard tickets.");
Console.WriteLine($"{(kids / totalTickets) * 100:f2}% kids tickets.");