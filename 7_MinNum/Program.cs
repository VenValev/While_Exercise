string s = "";
int n = int.MaxValue;
while (true)
{
    s = Console.ReadLine();
    if (s == "Stop")
    {
        break;
    }
    int i = int.Parse(s);
    if (n > i)
    {
        n = i;
    }
}
Console.WriteLine(n);