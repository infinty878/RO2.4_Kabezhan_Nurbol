using System;

class MainClass
{
    static void Main(string[] args)
    {

        int[] numbers1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int result = 0;
        foreach (int number in numbers1)
        {
            if (number > 0)
            {
                result++;
            }
        }
        Console.WriteLine($"Число элементов больше нуля: {result}");

        int[] numbers2 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int n = numbers2.Length;
        int k = n / 2;
        int temp1;
        for (int i = 0; i < k; i++)
        {
            temp1 = numbers2[i];
            numbers2[i] = numbers2[n - i - 1];
            numbers2[n - i - 1] = temp1;
        }
        Console.WriteLine();
        foreach (int i in numbers2)
        {
            Console.Write($"{i} \t");
        }

        int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
        int temp2;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp2 = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp2;
                }
            }
        }
        Console.WriteLine("\nВывод отсортированного массива");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}