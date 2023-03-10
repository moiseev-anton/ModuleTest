// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключително массивами.

using System;
using static System.Console;

Clear();
string[] example1 = { "hello", "2", "world", ":-)" };
string[] example2 = { "1234", "1567", "-2", "computer science" };
string[] example3 = { "Russia", "Denmark", "Kazan" };
PrintArray(example1);
Write(" -> ");
PrintArray(GetFiltredArray(example1));
WriteLine();
PrintArray(example2);
Write(" -> ");
PrintArray(GetFiltredArray(example2));
WriteLine();
PrintArray(example3);
Write(" -> ");
PrintArray(GetFiltredArray(example3));


// Нахождение размера итогового массива
int GetLengthNewArray(string[] array)
{
    int counter = 0;

    foreach (string item in array)
        if (item.Length < 4)
            counter++;

    return counter;
}

// Формирование итогового массива
string[] GetFiltredArray(string[] array)
{
    int length = GetLengthNewArray(array);

    if (length == array.Length)
        return array;

    string[] result = new string[length];
    int count = 0;

    for (int i = 0; count < length; i++)
        if (array[i].Length < 4)
            result[count++] = array[i];

    return result;
}

// Вывод массива строк
void PrintArray(string[] arr)
{
    Write($"[{String.Join(", ", arr)}]");
}