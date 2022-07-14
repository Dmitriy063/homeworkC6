// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double b1 = Prompt("Введите число b1: ");
double k1 = Prompt("Введите число k1: ");
double b2 = Prompt("Введите число b2: ");
double k2 = Prompt("Введите число k2: ");
double x = (b2 - b1) / (k1 - k2);
System.Console.WriteLine($"Точка пересечения ({x},{k2 * x + b2})");
