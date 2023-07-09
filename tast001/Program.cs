//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
void Main()
{
    int str = 3;
    int col = 4;
    int[,] array = new int[str, col];
    FillMatrix(array);
    PrintArray(array);
    for (int m = 1; m <= col; m++)
    {
        NewMatrixe(array);

    }
    PrintArray(array);

}

void NewMatrixe(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 1; j < array.GetLength(1); j++)
        {

            int max = 0;
            int macI = array[i, j - 1];
            if (macI < array[i, j])
            {
                macI = array[i, j - 1];
                max = array[i, j];
                array[i, j] = macI;
                array[i, j - 1] = max;
            }
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