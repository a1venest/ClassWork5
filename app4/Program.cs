// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

string BinarySystem = Convert.ToString(number,2);

Console.WriteLine($"Число {number} в бинарном виде равняется: {BinarySystem}");