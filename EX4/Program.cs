// найти максимум из 3 чисел введенных пользователем

using static System.Console;

Clear();
WriteLine("Введите 3 числа: ");
int num1 = int.Parse(ReadLine()!);
int num2 = int.Parse(ReadLine()!);
int num3 = int.Parse(ReadLine()!);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
WriteLine($"максимум из :{num1}, {num2}, {num3} = {max}");