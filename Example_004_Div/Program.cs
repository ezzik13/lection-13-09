// Найти частное

using static System.Console;

Clear();
WriteLine("Введите 2 числа: ");
double num1 = Convert.ToInt32(ReadLine());
double num2 = Convert.ToInt32(ReadLine());
double Div1 = num1 / num2;
WriteLine($"Частное {num1} и {num2} = {Div1}");
