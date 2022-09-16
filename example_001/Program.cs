//Посчитать сумму
// двух чисел введенных пользователем 

using static System.Console;

Clear();
Write ("Введите два числа: ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = Convert.ToInt32(ReadLine());
int Sum = num1+num2;
WriteLine($"Сумма = {Sum}");