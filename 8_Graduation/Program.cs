string name = Console.ReadLine();
int i = 0;
double sum = 0;
int br = 0;
while (i < 12)
{
    double g = double.Parse(Console.ReadLine());
    if (g < 4)
    {
        br++;
    }
    if (br > 1)
    {
        Console.WriteLine($"{name} has been excluded at {i} grade");
        break;
    }
    else
    {
        sum = sum + g;
    }
    i++;
}
if (i == 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {sum / 12.0:f2}");
}