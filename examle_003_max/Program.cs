// найти максимум из 5 чисел введенных пользователем

using static System.Console;

Clear();
WriteLine("Введите 5 чисел: ");
int num1 = int.Parse(ReadLine()!);
int num2 = int.Parse(ReadLine()!);
int num3 = int.Parse(ReadLine()!);
int num4 = int.Parse(ReadLine()!);
int num5 = int.Parse(ReadLine()!);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
if(num4 > max) max = num4;
if(num5 > max) max = num5;
WriteLine($"максимум из :{num1}, {num2}, {num3}, {num4}, {num5} = {max}");

