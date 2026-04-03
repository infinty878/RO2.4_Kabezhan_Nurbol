string[] words = { "apple", "banana", "cherry", "date" };

string[] reversewords = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    reversewords[i] = words[i];
}

Console.WriteLine(string.Join(", ", reversewords));
