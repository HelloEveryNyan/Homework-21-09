using System;

class Program
{
    static void Main()
    {
        int[] numbers = { new Random().Next(1, 101), new Random().Next(1, 101), new Random().Next(1, 101) };

        Console.WriteLine("Случайный массив из 3 чисел:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // Перевод строки

        int countEvenNumbers = Array.FindAll(numbers, num => num % 2 == 0).Length;

        Console.WriteLine($"Кол-во четных чисел в массиве: {countEvenNumbers}");
    }
}
