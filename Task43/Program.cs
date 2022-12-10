/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

int DataEntry(string invitation)
{
    Console.WriteLine(invitation);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int koeff_b1 = DataEntry("Введите b1:");
int koeff_k1 = DataEntry("Введите k1:");
int koeff_b2 = DataEntry("Введите b2:");
int koeff_k2 = DataEntry("Введите k2:");

double variable_x = (double)(koeff_b2 - koeff_b1) / (koeff_k1 - koeff_k2);
double function_y = (double)(koeff_k1 * variable_x) + koeff_b1;

System.Console.WriteLine($"Точка пересечения двух прямых: {variable_x} x {function_y}");