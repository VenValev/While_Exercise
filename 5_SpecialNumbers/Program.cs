int n = int.Parse(Console.ReadLine());
for (int i = 1111; i <= 9999; i++)
{
    int br = 0;
    for (int j = 0; j < 4; j++)
    {
        string s = i.ToString();
        int c = int.Parse(s[j].ToString());
        if (c != 0 && n % c == 0)
        {
            br++;
        }
    }
    if (br == 4)
    {
        Console.Write($"{i} ");
    }