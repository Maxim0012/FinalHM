/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/


// Задача 48
/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns);
PrintArray(array);
//////////////////////////////////////////////////
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 49
/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetSquare(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetSquare(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }

    }
}
*/
//Задача 51
/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int sum = GetSumMainNumbers(array);
PrintReport(array, sum);



/////////////////////////////////////////////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetSumMainNumbers(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}

void PrintReport(int[,] array, int Itog)
{
    Console.Write("Сумма эллементов главной диагонали: ");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i, i]);
        if (i < array.GetLength(0) - 1)
            Console.Write(" + ");
    }
    Console.Write($" = {Itog}");
}
*/
// Задача №53
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
Console.Clear();

int[,] array = GetArray(5, 10);
PrintArray(array);
ChangeRows(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray (int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(-10, 11);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array)
{
    int m = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[m - 1, j];
        array[m - 1, j] = temp;
    }
}
*/
//Задача 55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
Console.Clear();

int[,] array = GetArray(5, 10);
PrintArray(array);
Console.WriteLine();
int[,] transpose = TransposeArray(array);
PrintArray(transpose);

int[,] GetArray (int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(-10, 11);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] TransposeArray(int[,] array)
{
    int[,] outArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            outArray[j,i] = array[i,j];
        }
    }
    return outArray;
}
*/

//Задача 57
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*
Console.Clear();

int[,] array = GetArray(5, 10);
PrintArray(array);
Console.WriteLine();
int[,] frequencyArray = FrequencyArray(array);
PrintArray(frequencyArray);


int[,] GetArray (int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(-10, 11);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

bool IsContains (int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            return true;
        }
    }
    return false;
}

int[] GetUniqArray(int[,] array)
{
    int count = 0;
    int[] uniqTempArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!IsContains(uniqTempArray, array[i,j]))
            {
                uniqTempArray[count] = array[i,j];
                count++;
            }
        }
    }
    int[] uniqArray = new int[count];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        uniqArray[i] = uniqTempArray[i];
    }
    return uniqArray;
}

int[,] FrequencyArray(int[,] array)
{
    int[] uniqArray = GetUniqArray(array);
    Array.Sort(uniqArray);
    //Console.WriteLine(String.Join(" ", uniqArray));
    int[,] frequency = new int[uniqArray.Length, 2];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        frequency[i,0] = uniqArray[i];
        frequency[i,1] = GetCount(array, frequency[i,0]);
    }
    return frequency;
}

int GetCount(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number) count++;
        }
    }
    return count;
}
*/
//