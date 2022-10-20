// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
Write("Введите число > 0: ");
int num = int.Parse(ReadLine()!);
if (num <=0)
{
    Write("Achtung!");
    return;
}
int m = 1;
WriteLine(GetNumbers(num, m));
WriteLine(GetNumbers2(num, m));
// PrintNum(num);


string GetNumbers(int n, int m)
{
    if (m == n) return m.ToString();
    return GetNumbers(n, m + 1) + " " + m;
}

string GetNumbers2(int n, int m)
{
    return (m ==n) ? m.ToString() : GetNumbers(n, m + 1) + " " + m;

}

// void PrintNum(int n)
// {
//     while (n > 0)
//     {
//         Write($"{n} ");
//         n--;
//     }

// }
