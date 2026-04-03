int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
int even = 0;
int odd = 0;

for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

Console.WriteLine($"Even = {even}, Odd = {odd}");
