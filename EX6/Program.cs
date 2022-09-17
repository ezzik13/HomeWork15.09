// указать четное ли число введенное пользователем?

using static System.Console;

Clear();
WriteLine("Введите число: ");
int num1 = int.Parse(ReadLine()!);

if(num1%2==0)
{
    WriteLine($"Число {num1} четное");
}
else
{
     WriteLine($"Число {num1} нечетное");
}