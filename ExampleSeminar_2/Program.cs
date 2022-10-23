/* Напишите прогрумму, которая принимает на вход трехзначное число
и на выходе показывает последнюю цифру этого числа.*/

/* 
int GetLastDigit(int number)
{
    //int lastDigit = number % 10;
    //return lastDigit;
    return number % 10; // сокращенная строчка
}

int testNumber = 456;
// int lastDigit = GetLastDigit(testNumber);
// Console.WriteLine(lastDigit);
Console.WriteLine(GetLastDigit(testNumber));
*/

/* var rnd = new Random(); // var позволяет автоматически определить
// тип, который будет у нас в переменной
// var num = 32;

rnd.Next();

int b = rnd.Next();
*/

/*
void DoNothing()
{
    Console.WriteLine("Start!");
    return;
    Console.WriteLine("End!");

}

DoNothing();
*/

/* 
for (int i = 0; i < 100; i++)
{
    if (i == 20)
        break; // break используется для прерывания циклов
}
*/
/*
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        continue; // пропускаем одну итерацию в цикле
    Console.WriteLine(i);

}
*/

/*
Напишите программу, которая выводит случайное
число из отрезка [10,99] и показывает наибольшую цифру числа.

int BiggerDigit(int number)
{
    int result = -1;
    int one = number % 10;
    int two = number / 10;

    if (one > two)
    {
        result = one;
    }
    else
    {
        result = two;
    }
    return result;
}

int numberRandom = new Random().Next(10, 100);
Console.WriteLine(numberRandom);
Console.WriteLine(BiggerDigit(numberRandom));
*/
