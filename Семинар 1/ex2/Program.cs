Console.Clear();
/*
// 1. Организация ввода данных 
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

// 2. Решения
int sumNumbers = GetSumNumbers(A);

// 3. Формирования вывода
Console.WriteLine($"{A} -> {sumNumbers}");

///////////////////////////////////////////////////////////////
int GetSumNumbers(int number)
{
    int sum = 0;


    while (number > 0)
    {
        sum += number;
        number--;

    }




    return sum;
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


/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
//Задача №26
/*
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int result = CountNumber(A);

Console.WriteLine($"{A} -> {result}");
///////////////////////////////////////

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

int CountNumber(int number)
{
    int i = 0;

    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}
*/

//Задача №28
/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
/*
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int result = ProdNumbers(A);
Console.WriteLine($"{A} -> {result}");
////////////////////
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

int ProdNumbers(int number)
{
    int prod = 1;
    while (number > 0)
    {
        prod *= number;
        number--;
    }
    return prod;
}
*/
/*
int ProdNumbers(int number)
{
    int i = 0;
    int ProdNumbers = 0;
    while (i <= number)
    {
        sum += number;

    }
    return sum;
}
*/

//Задача№30
/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
Console.Write("[");
int count = 0;
while (count < 7)
{
    count++;
    Console.Write(new Random().Next(0, 2));
    Console.Write(", ");
}
Console.Write(new Random().Next(0, 2));
Console.WriteLine("]");
*/