//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

if (num <1 || num > 7) Console.WriteLine("Число не соответствует дню недели");
else if (num == 6 || num == 7) 
    Console.WriteLine("Выходной день");
    else 
        Console.WriteLine("Рабочий день");

 