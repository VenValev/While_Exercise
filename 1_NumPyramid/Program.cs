int a = int.Parse(Console.ReadLine());
int br = 1;
bool b = false;
for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (br > a)
        {
            b = true;
            break;
        }
        Console.Write($"{br} ");
        br++;
    }
    if (b) break;
    Console.WriteLine();
}