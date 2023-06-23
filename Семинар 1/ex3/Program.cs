//31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*
Console.Clear();
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");
//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// Возвращает сумму положительных чисел массива arr
int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
    }
    return positiveSum;
}
// Возвращает сумму отрицательных чисел массива arr
int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        negativeSum += el < 0 ? el : 0;
    }
    return negativeSum;
}
*/
/*
Console.Clear();

int Size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");

int[] array = GetArray(Size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

ChangeSignArray(array);
Console.WriteLine(String.Join(" ", array));

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}

void ChangeSignArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // итерация
    }
    return res;
}
*/




// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите Минимальное значение: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите Максимальное значение: ", "Ошибка ввода!");
int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));
int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
bool isFinded = IsExists(number, array);
Console.WriteLine($"{number}; массив {String.Join(" ", array)} -> {(isFinded ? "да" : "нет")}");
bool IsExists(int num, int[] arr)
{
    foreach (int elem in arr)
    {
        if (elem == num)
            return true;
    }
    return false;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}
*/