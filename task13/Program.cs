//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число");
string str = Console.ReadLine();

int n = str.Length;
if (n >= 3) Console.WriteLine("Третья цифра числа равна " + (str[2]));  
else Console.WriteLine("Третьей цифры нет");