// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число с: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c){
    Console.Write("Самое большое число = " + a);
}
else if (a < b && b > c){
    Console.Write("Самое большое число = " + b);
}
else{Console.Write("Самое большое число = " + c);
}
