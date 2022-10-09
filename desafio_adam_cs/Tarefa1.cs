using System;
using System.Xml;

class Tarefa1
{
    public static void Solve()
    {
        int[] originalArray = { 7, 5, 3, 9, 6, 4, 1 };
        int[] newArray = originalArray.Where(x => x != 4).ToArray();
        newArray = newArray.Select(x => (x == 9 ? 5 : x)).ToArray();
        int sum = newArray.Sum();
        Console.WriteLine("originalArray: ");
        PrintArray(originalArray);
        Console.WriteLine("newArray: ");
        PrintArray(newArray);
        Console.WriteLine("Sum of items in newArray: " + sum);
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1] + " ]\n");
    }
}
