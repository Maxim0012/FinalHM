/*//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X, Y);          // Вызов метода с передачей параметров по значению
                                     // -------------------------- Конец программы ----------------------------------
                                     // -------------------------Определение методов ---------------------------------
                                     // ------------------------------------------------------------------------------
                                     // Определяем функцию, выполняющую ввод значений координат
static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и выводящую в консоль номер четверти плоскости, в которой находится эта точка
static void PrintQuarterByCoords(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("1");
    else if (x < 0 && y > 0)
        Console.WriteLine("2");
    else if (x < 0 && y < 0)
        Console.WriteLine("3");
    else if (x > 0 && y < 0)
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
// ---------------------- Конец определения методов ----------------------------
*/





/*
Задача №1
Console.Clear();

int x;

Console.Write("Введите четверть координаты : ");
x = int.Parse(Console.ReadLine() ?? "");

if (x == 1)
    Console.WriteLine("x > 0  y > 0");
else if (x == 2)
    Console.WriteLine("x < 0  y > 0");
else if (x == 3)
    Console.WriteLine("x < 0  y < 0");
else if (x == 4)
    Console.WriteLine("x > 0  y < 0");
else
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
// Задача №2
/*
Console.Clear();

Console.WriteLine("Введите X1");
string userinput1 = Console.ReadLine() ?? "";
int X1 = int.Parse(userinput1);

Console.WriteLine("Введите Y1");
string userinput2 = Console.ReadLine() ?? "";
int Y1 = int.Parse(userinput2);

Console.WriteLine("Введите X2");
string userinput3 = Console.ReadLine() ?? "";
int X2 = int.Parse(userinput3);

Console.WriteLine("Введите Y2");
string userinput4 = Console.ReadLine() ?? "";
int Y2 = int.Parse(userinput4);

int K1 = (X2 - X1);
int K2 = (Y2 - Y1);

double result = Math.Sqrt(K1 * K1 + K2 * K2);
Console.WriteLine($"A {X1}{Y1}, B {X2}{Y2} --> {result}");
*/

//Задача №3
/*
Console.Clear();
Console.WriteLine("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;

Console.Write($"{a} -->");
while (b != a - 1)
{
    b++;
    Console.Write($" {b * b}, ");
}
b++;
Console.Write($" {b * b}. ");
*/