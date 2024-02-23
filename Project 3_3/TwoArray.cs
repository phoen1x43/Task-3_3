using System;

namespace Task3_3;

sealed class TwoArray : ParentArray, ITwoArray
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
        Console.WriteLine("Введите количество строк");
        int strings = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[strings, columns];
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rand.Next(0, 100);
            }
        }
        Console.WriteLine();
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите количество строк");
        int strings = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[strings, columns];
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Введите элемент массива");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }

    public override double CalculateAverage()
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                count += array[i, j];
                Console.WriteLine("Среднее значение в многомерном массиве:");
            }
        }
        return (double)count / (array.GetLength(0) * array.GetLength(1));
    }
    
    public void SnakePrint(int[,] array)
    {    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}