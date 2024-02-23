using System;

namespace Task3_3;

sealed class JaggedArray: ParentArray, IJaggedArray
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
        Console.WriteLine("Введите количество строк: ");
        int strings = Convert.ToInt32(Console.ReadLine());
        int[][] array = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            Console.WriteLine("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            array[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                array[i][j] = rand.Next(0, 100);
                Console.Write(array[i][j] + " ");
            }
            Console.Write('\n');
        }
        Console.WriteLine();
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите количество строк: ");
        int strings = Convert.ToInt32(Console.ReadLine());
        int[][] array = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            Console.WriteLine("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            array[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Введите элемент ступенчатого массива: ");
                array[i][j] = Convert.ToInt32(Console.ReadLine());
                Console.Write(array[i][j] + " ");
            }
            Console.Write('\n');
        }
        Console.WriteLine();
    }

    public override double CalculateAverage()
    {   
        int N = 0;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                N++;
                sum += array[i][j];
                Console.WriteLine("Среднее значение в ступенчатом массиве:");
            }
        }
        return sum / N;   
    }

    public void ModifyElements(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] % 2 == 0)
                {
                    array[i][j] = i * j;
                    Console.WriteLine("Обновленный трехмерный массив");
                }
            }
        }
        Console.Write(array);
    }

    public override void Print()
    {
        Console.WriteLine("Ступенчатый массив");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.Write('\n');
        }
        Console.WriteLine();
    }
}