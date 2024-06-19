/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


// Первоначальный массив будем задавать на старте выполнения алгоритма.

using System;
using static System.Console;
Clear();

string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

string[][] matrix = new string[][] {array1, array2, array3};


for (int i = 0; i < matrix.Length; i++)
{
    Write("[");
    PrintArray(matrix[i]);
    Write("]");

    Write(" -> ");

    Write("[");
    int length_array = GetLengthArray(GetArrayLimitLength(matrix[i]));
    PrintArray(GetResArray(GetArrayLimitLength(matrix[i]), length_array));
    WriteLine("]");
}


string[] GetArrayLimitLength(string[] arr)
{
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                res[j] = arr[i];
                j++;
            }
    }
    return res;
}


int GetLengthArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) cnt++;
    }
    return cnt;
}


string[] GetResArray(string[] arr, int length)
{
    string[] res = new string[length];
    for (int i = 0; i < length; i++) 
    {
        res[i] = arr[i];
    }
    return res;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]}");
        if (i != arr.Length - 1) Write(", ");
    }
}
