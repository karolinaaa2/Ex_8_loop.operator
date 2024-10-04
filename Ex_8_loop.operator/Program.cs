using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = GCD(a, b);
        Console.WriteLine($"Найбільший спільний дільник для {a} та {b}: {gcd}");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
