// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите N-ое число: ");
int number = int.Parse(Console.ReadLine());
int firstNumber = 1;


while (firstNumber <= number)
{
    if (firstNumber % 2 == 0){
        Console.Write(firstNumber + ", ");
    }
    firstNumber++;
        
}