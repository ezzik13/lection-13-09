//Посчитать сумму
//двух рандомных чисел от 1 до 25

using static System.Console;

Clear();
int num1 = new Random().Next(1,100);
int num2 = new Random().Next(1,100);
int Sum = num1+num2;
WriteLine($"Сумма {num1} + {num2} = {Sum}");