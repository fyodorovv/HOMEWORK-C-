// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = int.Parse(Console.ReadLine());
int sum = 0;
SumNumbers(number1,number2,sum);
void SumNumbers(int number1, int number2, int sum)
{
    if (number1 > number2) 
    {
        Console.WriteLine($"{sum}"); 
        return;
    }
    sum = sum + (number1++);
    SumNumbers(number1, number2, sum);
}