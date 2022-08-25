// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] Array()
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Вы ввели числа: [{string.Join(", ", array)}].");
    return array;
}

int Positive(int[] Array)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        if (Array[i] >= 0) count++;
    }
    Console.WriteLine($"Положительных числел: {count}.");
    return count;
}

Positive(Array());