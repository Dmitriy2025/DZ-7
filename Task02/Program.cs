// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Clear();
Console.Write("Введите число m: ");
int num_m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int num_n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Ackermann(num_m, num_n);

Console.WriteLine($"Функция Аккермана: А ({num_m}, {num_n}) = {Ackermann(num_m, num_n)}");
