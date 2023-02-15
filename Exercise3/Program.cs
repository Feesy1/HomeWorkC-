// Напишите программу,которая на вход принимает числа и выдаёт,явлется ли число чётным.

Console.WriteLine("Введите число . ");
int num1 = Convert.ToInt32(Console.ReadLine());

if  (num1 % 2 == 0)
{
    Console.WriteLine("Число делится на 2 и является четным . ");
}
else
{
    Console.WriteLine("Число не четное,так как не делится на цело на 2");
}