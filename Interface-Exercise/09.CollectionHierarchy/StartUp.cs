using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var numberOfRemoveOperations = int.Parse(Console.ReadLine());

        var firstCol = new List<string>();
        var secondCol = new List<string>();

        for (int i = 0; i < numberOfRemoveOperations; i++)
        {
            firstCol.Add(input[i]);
        }
        var couter = 0;
        var iter = input.Length - 1;
        while (couter != numberOfRemoveOperations)
        {
            secondCol.Add(input[iter]);
            iter--;
            couter++;
        }
        var firstLine = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            firstLine.Add(i);
        }
        int[] secondLine = new int[input.Length];
        Console.WriteLine(string.Join(" ", firstLine));
        Console.WriteLine(string.Join(" ", secondLine));
        Console.WriteLine(string.Join(" ", secondLine));
        Console.WriteLine(string.Join(" ", firstCol));
        Console.WriteLine(string.Join(" ", secondCol));

    }
}

