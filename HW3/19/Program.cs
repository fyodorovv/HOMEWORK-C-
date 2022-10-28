// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int numlength = num.Length;
if (numlength == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
        Console.WriteLine(num + " - число является палиндромом");
    else
        Console.WriteLine(num + " - не является числом палиндромом");
}
else
    Console.WriteLine(num + " - не пятизначное число");