﻿
// 4.	Запрашивает с клавиатуры два вещественных числа, и выводит на экран сумму и произведение данных чисел (вещественные числа выводятся с точностью до 3 знаков после запятой): 
// 5.	Запрашивает с клавиатуры два вещественных числа, и выводит на экран результат деления первого числа на второе (вещественные числа выводятся с точностью до 3 знаков после запятой): 
// 6.	Запрашивает с клавиатуры три вещественных числа, и выводит на экран числа и их сумму (вещественные числа выводятся с точностью до 2 знаков после запятой): 


// 1.	Запрашивает с клавиатуры два целых числа, и выводит на экран сумму данных чисел.
// 2.	Запрашивает с клавиатуры два целых числа, и выводит на экран разницу и произведение данных чисел. 
// 3.	Запрашивает с клавиатуры три целых числа, и выводит на экран сумму данных чисел: 

Console.WriteLine("Введите целое число a:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число с:");
int number3 = Convert.ToInt32(Console.ReadLine());

int sum = number1 + number2;
int diff = number1 - number2;
int product = number1 * number2;
int sum2 = number1 + number2 + number3;

Console.WriteLine($"Сумма чисел a и b = {sum}");
Console.WriteLine($"Разница между a и b = {diff}");
Console.WriteLine($"Произведение чисел a и b = {product}");
Console.WriteLine($"Сумма чисел a, b и c = {sum2}");




