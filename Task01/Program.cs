// Задача 1 Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string InterateAndPrint(int start, int end)
{
    if (start == end)
        return start.ToString();
    return $"{start} {InterateAndPrint(start + 1,end)}";
}

Console.Clear();
Console.Write("Введите число M: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int last = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (first > last)
{
    int temp;
    temp = first;
    first = last;
    last = temp;
}

if (first < 0 || last < 0)
{
    Console.WriteLine("Числа M и N должны быть натуральными! Запустите программу заново");
    Console.WriteLine();
}
else 
{
    Console.WriteLine($"Натуральные числа от M до N: {InterateAndPrint( first, last)}");
    Console.WriteLine();
}
