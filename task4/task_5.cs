int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
int[] a = new int[raw.Length];
int b = 0;

foreach (int c in raw)
{
    if (Array.IndexOf(a, c, 0, b) == -1)
    {
        a[b] = c;
        b++;
    }
}

for (int i = 0; i < b; i++)
{
    Console.Write(a[i] + " ");
}

