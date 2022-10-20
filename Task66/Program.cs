// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Введите первое число: ");
int m = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int n = int.Parse(ReadLine()!);
int sum = 0;
WriteLine(GetSum(m, n));
//sum = 0; // Если не обнулю сумму, то итог во 2-й ф-ции получается больше.
WriteLine(GetSum2(m, n));         // Не подскажите почему? Заранее спасибо.


int GetSum(int num1, int num2)
{
    if (num1 == num2) return sum += num2;
    return GetSum(num1, num2 - 1) + num2;
}

int GetSum2(int num1, int num2)
{
    return num1 == num2 ? sum += num2 : GetSum2(num1, num2 - 1) + num2;
}
