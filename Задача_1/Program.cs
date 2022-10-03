/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 100)
{
    number /= 10;
    result = number % 10;
}
Console.Write("Вторая цифра числа: " + result);