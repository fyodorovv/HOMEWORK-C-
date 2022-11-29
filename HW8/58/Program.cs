// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, 
// там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите кол-во строк:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine());
int [,] firstArray = new int [rows,columns];
int [,] secondArray = new int [rows,columns];
int[,] resultArray = new int[rows, columns];
GetArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();
GetArray(secondArray);
PrintArray(secondArray);

if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Error ");
    return;
}
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}
Console.WriteLine();
PrintArray(resultArray);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(1,10);
        }   
    }

}
void PrintArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}