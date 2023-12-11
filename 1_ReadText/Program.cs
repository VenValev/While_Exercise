int i = 0;
bool b = true;
while (i < 9)
{
    string s = Console.ReadLine();
    if (s == "S top") b = false;
    if (b == true)
    {
        Console.WriteLine(s);
    }
    i++;
}