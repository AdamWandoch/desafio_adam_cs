using System;
using System.Xml;

class Tarefa1
{
    public static void Solve()
    {
        int[] originalArray = { 7, 5, 3, 9, 6, 4, 1 };
        int[] newArray = originalArray.Where(x => x != 4).ToArray();
        for (int i = 0; i < newArray.Length; i++)
        {
            if (newArray[i] == 9) newArray[i] = 5;
        }
        int sum = newArray.Sum();
        Console.WriteLine("originalArray: ");
        printArray(originalArray);
        Console.WriteLine("newArray: ");
        printArray(newArray);
        Console.WriteLine("Sum of items in newArray: " + sum);

    }


    static void printArray(int[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1] + " ]");
    }

}
