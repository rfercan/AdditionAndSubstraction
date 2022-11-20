using System;

int sum = 0;
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 1)
    {
        sum += i;
    }

}
Console.WriteLine(sum);
sum = 0;
for (int i = 10; i >= 0; i--)
{
    if (i % 2 == 0)
    {
        sum += i;
    }

}
Console.WriteLine(sum);