// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string [] array = {"1234", "work", "-2", ":-)"}; // задаем массив 
PrintArray(array);
Console.Write(" -> ");
int countElem = CountLength(array);
string[] newString = NewStringArray (array, countElem);
PrintArray(newString);

int CountLength(string[] arr) // поиск символов 
{
    int countElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i].Length <= 3) countElem++;
    }
    return countElem;
}

string[] NewStringArray (string[] arr, int countElem) // запись нового массива 
{
    string[] newArray = new string[countElem];
    int arrIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[arrIndex] = arr[i];
            arrIndex++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
