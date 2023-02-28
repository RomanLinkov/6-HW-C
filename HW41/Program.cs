// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.numbersFromUser
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int m = NumberInput("Количество вводимых чисел M: ");

int[] arrayFromUser = ArrayIntInput(m);

int countPositiveNumbers=CountPositiveNumbers(arrayFromUser);

PrintArrayInt(arrayFromUser);
Console.Write($" -> {countPositiveNumbers}");
Console.WriteLine();

int CountPositiveNumbers(int[] array1)
{
    int resulst=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i]>0) resulst++;
    }
    return resulst;
}

int[] ArrayIntInput(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i]=NumberInput($"Введите число {i+1}: ");
    }
    Console.WriteLine();
    return array;
}

void PrintArrayInt(int[] a)
{
    
    for (int i=0; i<a.Length;i++)
    {
        Console.Write($"{a[i]}");
        if (i<a.Length-1)Console.Write($", ");
    }   
}

int NumberInput(string msg)

{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}