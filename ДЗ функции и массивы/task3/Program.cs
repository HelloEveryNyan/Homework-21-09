using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите массив: ");
        int length = int.Parse(Console.ReadLine());

        double[] arr = new double[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        double min = arr.Min();
        double max = arr.Max();
        double difference = max - min;

        Console.WriteLine($"Мин элемент: {min}");
        Console.WriteLine($"Макс элемент: {max}");
        Console.WriteLine($"разница : {difference}");
    }
}
