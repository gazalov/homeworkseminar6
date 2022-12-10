/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

Console.Clear();
int M = 5;
int count = 0;

void DataEntry()
{
    System.Console.Write($"Пожалуйста, введите {M} целых чисел:");
    System.Console.WriteLine();
    for (int i = 0; i < M; i++)
    {
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество чисел больше нуля: {count}");
}
DataEntry();