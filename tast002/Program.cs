//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Main()
{
    int column = KeyboardInput("Введите число колонок:");
    int line = KeyboardInput("Введите число строк:");
    int row = KeyboardInput("Введите начало генерации:");
    int col = KeyboardInput("Введите конец генерации:");
    int[,] array = new int[line, column];
    FillMatrix(array, col, row);
    PrintArray(array);
    Sum(array);
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
void Sum(int[,] array)
{
    int[] sumArr = Array.Empty<int>();
    //int[] arr = new int[4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;


        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        sumArr = sumArr.Append(sum).ToArray();
    }
    System.Console.WriteLine("(" + string.Join(",", sumArr) + ")");
    int a = Rez(sumArr);
    System.Console.WriteLine(a);
}
int Rez(int[] sumArr)
{
    int min = sumArr[0];
    for (int k = 1; k < sumArr.Length; k++)
    {
        if (min > sumArr[k])
        {
            min = sumArr[k];
        }
    }
    return min;
}

int KeyboardInput(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillMatrix(int[,] arr, int col, int row)
{
    //double[,] arr = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(row, col + 1);
        }
    }
}
Main();
