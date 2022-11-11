// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Write("Введите строку:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите столбец:");
int columns = int.Parse(Console.ReadLine());
int [,] array = new int [6,4];
GetArray(array);
PrintArray(array);
if (rows < array.GetLength(0) && columns < array.GetLength(1)) 
{
    Console.WriteLine($"Число - {array[rows, columns]}");
}
else 
{
    Console.WriteLine($"[{rows},{columns}] -> такого числа в массиве нет");
}
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
void PrintArray ( int [,] arrray)
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