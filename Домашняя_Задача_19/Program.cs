﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом (одинаково читается назад и вперед).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int i =  Math.Abs(Convert.ToInt32(Console.ReadLine()));

if ((i % 10) == (i / 10000) && (((i % 100) / 10) == ((i / 1000) % 10)))
{
    Console.WriteLine("Палиндром");
}

else
{
Console.WriteLine("Не палиндром или не пятизначное");
}