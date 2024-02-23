using System;

namespace Task3_3;

public class Program
{
    static void Main(string[] args)
    {
        ParentArray[] parentArray = new ParentArray[3];

        parentArray[0] = new OneArray();
        parentArray[1] = new TwoArray();
        parentArray[2] = new JaggedArray();

        foreach (ParentArray item in parentArray)
        {
            item.Print();
            Console.WriteLine("Среднее значение в массиве: " + item.CalculateAverage());
            Console.WriteLine();
        }
    }

}