string[] words = {"apple", "banana", "cherry", "date"};

for (int i = 0; i < words.Length / 2; i++)
{

    string a = words[i];

    int j = words.Length - 1 - i;

    words[i] = words[j];
    words[j] = a;
}

Console.WriteLine(string.Join(" ", words));
