// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите первое натуральное число: ");
int number1 = UserInput();
if (number1 <= 0) Environment.Exit(0);
Console.Write("Введите первое натуральное число: ");
int number2 = UserInput();
if (number2 <= 0) Environment.Exit(0);

int result = SumNumbersInBetween(number1, number2);
Console.Write($"M = {number1}; N = {number2} -> {result}");
SumNumbersInBetween(number1, number2);

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

int SumNumbersInBetween(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 + SumNumbersInBetween(num1 + 1, num2);
}