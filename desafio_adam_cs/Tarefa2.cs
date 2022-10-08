using System;
using System.Xml;


class Tarefa2
{
    public static void Solve()
    {
        int[] numbers = new int[] { 2, 7, 11, 15 };
        int target = 22;
        findIndexes(numbers, target);

    }

    static void findIndexes(int[] inputArray, int sum)
    {
        for (int index1 = 0; index1 < inputArray.Length; index1++)
        {
            for (int index2 = index1 + 1; index2 < inputArray.Length; index2++)
            {
                if (inputArray[index1] + inputArray[index2] == sum)
                {
                    Console.WriteLine();
                    Console.WriteLine("Found indexes: " + index1 + " and " +
                    index2);
                    return;
                }
            }
        }
        Console.WriteLine("No solution found.");
    }

}
