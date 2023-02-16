//Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
Console.WriteLine("Введите число . ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>=0&&num<=9)
{
    Console.WriteLine("такой цифры нет");
}

if (num<=99&&num>9)
{
    Console.WriteLine(num % 10);
}
if (num<=999&&num>99)
{
    Console.WriteLine(num % 100 / 10);
}
if (num<=9999&&num>999)
{
    Console.WriteLine(num % 1000 / 100);
}
if (num<=99999&&num>9999)
{
    Console.WriteLine(num % 10000 / 1000);
}
if (num<=999999&&num>99999)
{
    Console.WriteLine(num % 100000 / 10000);
}
if (num<=9999999&&num>999999)
{
    Console.WriteLine(num % 1000000 / 100000);
}
if (num<=99999999&&num>9999999)
{
    Console.WriteLine("Слишком большое число");
}