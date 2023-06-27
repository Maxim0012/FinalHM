// Задача 40
//Напишите программу, которая принимает на вход три 
//числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
Console.Clear();

int number1 = GetNumberFromUser("Введите длину первой стророны","ошибка ввода!");
int number2 = GetNumberFromUser("Введите длину второй стророны","ошибка ввода!");
int number3 = GetNumberFromUser("Введите длину третьей стророны","ошибка ввода!");

ExistTriangle(number1, number2, number3);


bool ExistTriangle(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
    {
        Console.WriteLine($"{n1}, {n2}, {n3} -> такой треугольник существует");
    }
    else Console.WriteLine($"{n1}, {n2}, {n3} -> такой треугольник НЕ существует");
    return true;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
    Console.WriteLine (message);
    if (int.TryParse(Console.ReadLine(), out int userNumber))
        return userNumber;
    
    Console.WriteLine (errorMessage);
    }
}
*/


//Задача №42
int num = 45;
int count = 0;
int temp = num;
while (temp > 0)
{
    count++;
    temp /= 2;

}
int[] mass = new int[count];

int i = mass.Length - 1;
while (num > 0)
{
    mass[i] = num % 2;
    num /= 2;
    i--;
}
Console.WriteLine(string.Join("", mass));