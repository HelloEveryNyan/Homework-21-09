using System;

class Program
{
    static void Main()
    {
        Console.Write("введите длину массива: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(1, 101);
        }

        Console.WriteLine("полученый массив:");
        Console.WriteLine(string.Join(" ", arr));

        int sum = 0;
        for (int i = 1; i < length; i += 2)
        {
            sum += arr[i];
        }

        Console.WriteLine($"сумма на нечетных позициях: {sum}");
    }
}
