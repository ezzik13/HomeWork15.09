// сравнить 2 числа введенных пользователем

using static System.Console;

Clear();
WriteLine("Введите 2 чисела: ");
int num1 = int.Parse(ReadLine()!);
int num2 = int.Parse(ReadLine()!);
int max=0;
int min=0;

if(num2 > num1)
{
     max = num2;
     min = num1;
}
else
{
     max = num1;
     min = num2;
}
WriteLine($"{max}>{min}");
