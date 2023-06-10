/*Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int result = userNumber*userNumber;

Console.WriteLine($" {userNumber*2} -> {result*2} ");
*/

/*Console.Clear();
Console.Write("Введите целое число 1: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
Console.Write("Введите целое число 2: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
if ( userNumber == userNumber1*userNumber1);{
    Console.WriteLine ("yes");}

if ( userNumber != userNumber1*userNumber1);{
    Console.WriteLine ("no");}
    */

/*Console.Clear();
Console.Write("Введите целое число : ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if()
*/


//Домашка №2
/*
Console.Clear();
Console.Write("Введите целое число 1: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
Console.Write("Введите целое число 2: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);


if (userNumber > userNumber1)
{
    Console.WriteLine($"Большее = {userNumber} Меньшее =  {userNumber1}");
    ;
}

else
{
    Console.WriteLine($"Большее =  {userNumber1} Меньшее =  {userNumber} ");
}
*/







//Домашка №4
/*
Console.Write("Введите целое число 1: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
Console.Write("Введите целое число 2: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
Console.Write("Введите целое число 3: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

int max = userNumber;

if (userNumber1 > max)
{
    max = userNumber1;
}
if (userNumber2 > max)
{
    max = userNumber2;
}
Console.WriteLine($"Максимальное число: {max}");
*/

//Домашка №6
/*
Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber % 2 == 0)
{
    Console.WriteLine($"Число {userNumber} четное");
}
else
{
    Console.WriteLine($"Число {userNumber} нечетное");
}
*/

//Домашка №8
Console.Clear();
int i = 1;

Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
while (i <= userNumber)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
