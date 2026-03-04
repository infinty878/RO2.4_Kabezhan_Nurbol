using System;

class MainClass
{
    static void Main()
    {

        Console.WriteLine("Exercise 1");
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("the first number is greater than the second");
        }
        else if (b > a)
        {
            Console.WriteLine("the first number is less than the second");
        }
        else
        {
            Console.WriteLine("the numbers are equal");
        }

        Console.WriteLine("Exercise 2");
        Console.Write("Enter the number: ");
        int c = int.Parse(Console.ReadLine());

        if (5 < c && c < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("Exercise 3");
        Console.Write("Enter the number: ");
        int d = int.Parse(Console.ReadLine());


        if (d == 5 || d == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("Exercise 4");
        Console.Write("Enter the number: ");
        double e = Convert.ToDouble(Console.ReadLine());

        double f;

        if (e < 100)
        {
            f = 0.05;
        }
        else if (e >= 100 && e <= 200)
        {
            f = 0.07;
        }
        else
        {
            f = 0.10;
        }

        double total = e + e * f;
        Console.WriteLine(total);

        Console.WriteLine("Exercise 5");
        Console.Write("Enter the number: ");
        double g = Convert.ToDouble(Console.ReadLine());

        double t;

        if (g < 100)
        {
            t = 0.05;
        }
        else if (g >= 100 && g <= 200)
        {
            t = 0.07;
        }
        else
        {
            t = 0.10;
        }
        double bonus = 15;

        double total2 = g + g * t + bonus;
        Console.WriteLine(total2);


        Console.WriteLine("Exercise 6");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.Write("Enter operation number: ");
        int m = int.Parse(Console.ReadLine());


        switch (m)
        {
            case 1:
                Console.WriteLine("Addition");
                break;

            case 2:
                Console.WriteLine("Subtraction");
                break;

            case 3:
                Console.WriteLine("Multiplication");
                break;

            default:
                Console.WriteLine("the operation is undefined");
                break;
        }


        Console.WriteLine("Exercise 7");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.Write("Enter operation number: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        int a1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b1 = int.Parse(Console.ReadLine());

        switch (h)
        {
            case 1:
                Console.WriteLine($"Addition: {a1} + {b1} = {a1 + b1}");
                break;

            case 2:
                Console.WriteLine($"Subtraction: {a1} - {b1} = {a1 - b1}");
                break;

            case 3:
                Console.WriteLine($"Multiplication: {a1} * {b1} = {a1 * b1}");
                break;

            default:
                Console.WriteLine("the operation is undefined");
                break;
        }

    }
}