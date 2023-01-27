// Напишите прогр, кот по заданному номеру четверти показывает возможный диапазон 
//координат

Console.Write("Напишите номер четверти: ");
int X = Convert.ToInt32(Console.ReadLine());

if (X < 1 && X > 4)
{
    Console.Write("Введите число от 1 до 4");
}

else if (X == 1)
{
    Console.Write("Диапазон координат: X > 0; Y > 0");
}

else if (X == 2)
{
    Console.Write("Диапазон координат: X < 0; Y > 0");
}

else if (X == 3)
{
    Console.Write("Диапазон координат: X < 0; Y < 0");
}

else if (X == 4)
{
    Console.Write("Диапазон координат: X > 0; Y > 0");
}