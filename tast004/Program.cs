//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
void Main()
{
    int i = Num("Введите x:");
    int j = Num("Введите y:");
    int m = Num("Введите z:");
    int[,,] kub = new int[i, j, m];
    FillMatrix(kub);
    PrintArray(kub);
    Arr(kub);
}
int Num(string text)
{
    System.Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
void FillMatrix(int[,,] arr)
{
    //double[,] arr = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(2); m++)
            {
                arr[i, j, m] = rand.Next(10, 100);
            }
        }
    }
}
void Arr(int[,,] kub)
{
    for (int i = 0; i < kub.GetLength(0); i++)
    {
        for (int j = 0; j < kub.GetLength(1); j++)
        {
            for (int m = 0; m < kub.GetLength(2); m++)
            {

                System.Console.Write(kub[i, j, m] + "(" + i + ", " + j + ", " + m + ")" + ", ");

            }
            System.Console.WriteLine("\t");
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {

                System.Console.Write(array[i, j, m] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}
Main();

