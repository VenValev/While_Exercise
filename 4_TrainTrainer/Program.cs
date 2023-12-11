int n = int.Parse(Console.ReadLine());
double totalAverage = 0;
int br = 0;
while (true)
{
    double sumAverage = 0;
    string s = Console.ReadLine();
    if (s == "Finish") break;
    for (int i = 0; i < n; i++)
    {
        double a = double.Parse(Console.ReadLine());
        sumAverage += a;
    }
    Console.WriteLine($"{s} - {sumAverage / n:f2}.");
    br++;
    totalAverage += sumAverage / n;
}
Console.WriteLine($"Student's final assessment is {totalAverage / br:f2}.");