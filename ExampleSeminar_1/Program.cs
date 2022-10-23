/* 
Задача номер 1. Напишите программу, которая на вход принимает 
число и выдает его квадрат (число умноженное на само себя)
*/
// !Console.WriteLine("Введите значение: ");
// !int number = int.Parse(Console.ReadLine());
// number = Convert.ToInt32(Console.ReadLine()!);

// int square = number * number;

// Console.WriteLine(square);
// !!Console.Write("Квадрат числа = ");
// !!Console.WriteLine(number * number);

/* Форматирование строки:
Console.Write($"Квадрат числа = {number * number}");
*/

/* Записать строку, а потом ее преобразовать 
string inputString = Consolr.ReadLine();
int number = int.Parse(inputString);
*/

// Math.Pow

/*
Пример условия while

int i = 0;
while (i<5)
{
    Console.WriteLine("!!!");
    i += 1; или i++;
}

Можно также сократить через цикл for :

for (int i = 0; i < 5; i++ )
{
    Console.WriteLine("!!!");
}

*/

/* Пример условия if

int a =5;
bool isNumberEquals5 = a == 5;

if (!isNumberEquals5)
{

}
*/


//short c;

/*
Задача номер 1. Напишите программу, которая на вход принимает два числа
и проверяет, является ли второе число квадратом первого.
*/

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

bool isNumberEqualsA = a * a == b;

if (isNumberEqualsA)
{
    Console.WriteLine($"Второе число b = {b} является квадратом Первого числа a = {a} ");
}

if (!isNumberEqualsA)
{
    Console.WriteLine($"Второе число b = {b} не является квадратом Первого числа a = {a} ");
}

/* Задание номер 2. Напишите программу, 
которая будет выдавать название дня недели
по заданному номеру.


*/