// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void FillAndPrintArray(int[] array)
{   
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
    Console.Write("Изначальный массив:\t");
    Console.Write(string.Join(" ", array));
}

string ChangeOrder(int[] array, int index)
{   
    if (index < 0)
         return string.Empty;
    return $"{array[index]} {ChangeOrder(array, index - 1)}";
}

Console.Clear();
int [] array = new int [10];
FillAndPrintArray(array);
Console.WriteLine();

Console.Write("Перевернутый массив:\t");
Console.WriteLine(ChangeOrder(array, array.Length - 1));

