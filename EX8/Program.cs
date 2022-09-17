// Вывести все четные числа  от 1 до числа введенного пользователем?

using static System.Console;

Clear();
WriteLine("Введите число: ");
int num1 = 1;
int num2 = int.Parse(ReadLine()!);
while(num1<=num2)
{
    if(num1 % 2==0)
    Write ($"{num1}, ");
    num1++;}