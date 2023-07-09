//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void Main()
{
    int a = Num("Введите длину первой матрицы");
    int a1 = Num("Введите ширину первой матрицы");
    int b = Num("Введите длину второй матрицы");
    int b1 = Num("Введите ширину второй матрицы");
    if (a != b1 && a1 != b)
    {
        System.Console.WriteLine("Так нельзя, длина одной матрицы должна быть ровна ширине другой!");
    }
    else
    {
        int[,] array = new int[a, a1];
        FillMatrix(array);
        PrintArray(array);
        int[,] arrayTwo = new int[b, b1];
        FillMatrix(arrayTwo);
        PrintArray(arrayTwo);
        RezMatrrix(array, arrayTwo);
    }
}
int Num(string text)
{
    System.Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void RezMatrrix(int[,] array, int[,] arrayTwo)
{
    int[] sumArr = Array.Empty<int>();
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < arrayTwo.GetLength(1); l++)
        {
            int sum = 0;
            for (int m = 0; m < array.GetLength(1) && m < arrayTwo.GetLength(0); m++)
            {
                sum = sum + array[k, m] * arrayTwo[m, l];
            }
            sumArr = sumArr.Append(sum).ToArray();
        }
    }
    int[,] arrNew = new int[array.GetLength(0), arrayTwo.GetLength(1)];

    {
        for (int g = 0; g < sumArr.Length; g++)
        {
            for (int i = 0; i < arrNew.GetLength(0); i++)


                for (int j = 0; j < arrNew.GetLength(1); j++)

                {

                    arrNew[i, j] = sumArr[g];
                    g++;
                }
            PrintArray(arrNew);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FillMatrix(int[,] arr)
{
    //double[,] arr = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
}
Main();
