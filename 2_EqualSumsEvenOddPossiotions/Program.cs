int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    int sum1 = 0; //chetni
    int sum2 = 0; //nechetni
    string cnum = i.ToString();
    for (int j = 0; j < cnum.Length; j++)
    {
        int dig = int.Parse(cnum[j].ToString());
        if (j % 2 == 0)
        {
            sum1 += dig;
        }
        else
        {
            sum2 += dig;
        }
    }
    if (sum1 == sum2)
    {
        Console.Write($"{i} ");
    }

}