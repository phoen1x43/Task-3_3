using System;
using Task3_3;

namespace Task3_3;

sealed class OneArray : ParentArray, IOneArray
{
    public void RndOrHands(bool t = false)
    {
        if (t == false)
        {
            RndFill();
        }
        else
        {
            FillByUser();
        }
    }

    public override void RndFill()
    {
        Random rand = new Random();
        int n = rand.Next(1, 15);
        int[] array = new int[n];
        for (int i = 0; i<n; i++)
        {
            array[i] = rand.Next(1, 100);
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите количество элементов одномерного массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i<n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public override double CalculateAverage()
    {
        int count = 0;
        foreach (int i in array)
        {
            count += i;
            Console.WriteLine("Среднее значение в одномерном массиве:");
        }
        return count / n;
    }

    public void DeleteDuplicates(int[] array)
    {
        int[] NonDuplicates = new int[];
        int nonduplicatesindex = 0;
        Array.Sort(array);
        foreach (int i in array)
        {
            if ((array[i] != array[i+1]) && (array[i] != array[i-1]))
            {
                NonDuplicates[nonduplicatesindex] = array[i];
                nonduplicatesindex++;
            }
        }
        array = new int[nonduplicatesindex];
        for (int i = 0; i < nonduplicatesindex; i++)
        {
            array[i] = NonDuplicates[i];
        }
        Console.WriteLine(NonDuplicates);
    }

    public override void Print()
    {
        Console.WriteLine("Одномерный массив:");
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}