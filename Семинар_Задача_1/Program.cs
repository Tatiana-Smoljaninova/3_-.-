﻿//<<ОДНОМЕРНЫЕ МАССИВЫ >>
//есть массив - набор однотипных данных. М.б. массив данныых или массим массивов
string f1 = "Anna1";
string f2 = "Anna2";
string f3 = "Anna3";
string f4 = "Anna4";
string f5 = "Anna5";

//создаем массив "[]" строк "string"  с именем "f"
//string[] f; // это просто пустой массив
string[] f = {f1, f2, f3, "Anna1", Convert.ToString(1)}; //заполняем массив переменными или наименованиями переменных
//int[] num; // определили массив числе и дали ему название
//int[] num = new int[5]; //определили кол-во элементов массива - 5 эл-тов

Console.WriteLine(f[2]); //выведи элемент массива с индексом 2

Console.WriteLine(f[4]);

f[1] = "Anna6";
Console.WriteLine(f[1]);

Console.WriteLine(f.Length); // находим длинну массива

// >> Вариант 1: перебрать все элементы массива
for (int i = 0; i < f.Length; i++)
{
    Console.WriteLine(f[i]); //вывести все значения массива
}

// >> Вариант 2: перебрать все элементы массива
int[] num = {1, 2, 3, 4, 5};

foreach (int n in num) //для каждого целого n в массиве num - вывести все числа массива
{
    if (n < 2)
    Console.WriteLine(n);
}

// извлечь квадратный корень из числа
double num = Math.Sqrt // квадратный корень числа
double num = Math.Pow(n, 3); //возведение числа n в степень 3 