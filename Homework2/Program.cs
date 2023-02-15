// Напишите программу которая, принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число . ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число . ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число . ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Первое число больше остальных . ");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Второе число больше остальных");
}
else
{
    Console.WriteLine("Третье число больше остальных");
}