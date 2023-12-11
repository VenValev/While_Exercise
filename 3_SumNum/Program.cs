int n = int.Parse(Console.ReadLine());
int sum = 0;
int i = 0;
while (sum + i <= n)
{
    i = int.Parse(Console.ReadLine());
    sum += i;
}
Console.WriteLine(sum);