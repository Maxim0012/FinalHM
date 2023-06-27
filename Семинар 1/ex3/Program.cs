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

//Задача 25
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine() ?? "");
int size = a;

for (int i = 1; i < b; i++)
{
    size = size * a;
}
Console.WriteLine($"{a} в степени {b} = {size}");
*/

//Задача 27
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "");
int sum = 0;

while (a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
}
Console.WriteLine($"сумма всех цифр в числе равна:  {sum}");
*/

//Задача№29
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Write("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");

Console.Write("[");
int count = 1;
while (count < size)
{
    count++;
    Console.Write(new Random().Next(min, max));
    Console.Write(", ");
}
Console.Write(new Random().Next(min, max));
Console.WriteLine("]");
*/