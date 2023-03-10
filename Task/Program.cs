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

// Нахождение размера итогового массива
int GetLengthNewArray(string[] array)
{
    int counter = 0;

    foreach (string item in array)
        if (item.Length < 4)
            counter++;

    return counter;
}
