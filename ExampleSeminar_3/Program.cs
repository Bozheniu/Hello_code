// Напишите программу,которая принимает на вход координаты точки (X и Y),
// причем X != 0 и Y!=0 и выдает номер четверти плоскости, в которой находится эта точка.

/*
int GetNumberOfPlane(int x, int y)
{
    if (x == 0 || y == 0) return -1;

    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y > 0) return 4;
    else return -1;
}

void PrintNumberOfPlane(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Неверные координаты");
        return;
    }

    int numberOfPlane;
    if (x > 0 && y > 0) numberOfPlane = 1;
    else if (x < 0 && y > 0) numberOfPlane = 2;
    else if (x < 0 && y < 0) numberOfPlane = 3;
    else if (x > 0 && y > 0) numberOfPlane = 4;
    else numberOfPlane = -1;

    Console.WriteLine($"Номер плоскости: {numberOfPlane}");
}

int x = -19, y = 20;

//Console.WriteLine($"Номер плоскости: {GetNumberOfPlane(x, y)}");
PrintNumberOfPlane(x, y);
*/

// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти X, Y).

/*
void Range(int numberPlace)
{
    if (numberPlace == 1) Console.WriteLine("Координаты в диапазоне +X, +Y");
    else if (numberPlace == 2) Console.WriteLine("Координаты в диапазоне +X, -Y");
    else if (numberPlace == 3) Console.WriteLine("Координаты в диапазоне -X, +Y");
    else if (numberPlace == 4) Console.WriteLine("Координаты в диапазоне -X, -Y");
}
Console.WriteLine("Введите номер плоскости ");
int numberPlace = int.Parse(Console.ReadLine()!);
Range(numberPlace);
*/

/* Проверяем, ввел ли пользователь соответсвующие значение для нашей задачи,
используя TryParse

int number1, number2;

Console.WriteLine(
    int.TryParse(Console.ReadLine(), out number1)
);
Console.WriteLine(number1);

Console.WriteLine(
    int.TryParse(Console.ReadLine(), out number2)
);
Console.WriteLine(number2);
*/

int number1, number2;

while (!int.TryParse(Console.ReadLine(), out number1) ||
    number1 < 1 ||
    number1 > 4)
{
    Console.WriteLine("Ошибка!");
}
Console.WriteLine(number1);





