// даны два числа. Показать большее и меньшее число
Console.WriteLine("введите два числа");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int max=a;
int min=b;
if (a>b)
{
    max=a;
    min=b;
}
else
{
    max=b;
    min=a;
}
Console.Write("максимальное число ");
Console.WriteLine(max);
Console.Write("минимальное число ");
Console.WriteLine(min);
