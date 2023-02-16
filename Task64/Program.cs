// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите натуральное число: ");
int number = UserInput();
if (number <= 0) Environment.Exit(0);
Console.Write($"N = {number} -> ");
NumbersInBetween(number);

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

void NumbersInBetween(int num)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    NumbersInBetween(num - 1);
}