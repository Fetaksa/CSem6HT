// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] NumbersInput(int mx)
{
    int[] userNumbers = new int[mx];
    for (int i = 0; i < mx; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        userNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userNumbers;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveIntegerCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] arr = NumbersInput(m);
PrintArray(arr);
Console.WriteLine($"Вы ввели {PositiveIntegerCount(arr)} чисел больше нуля.");
