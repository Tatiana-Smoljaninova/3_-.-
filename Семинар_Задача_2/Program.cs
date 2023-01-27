// Напишите прогр, кот принимает на вход координаты точки (X и Y), причем X !=0 и Y!=0
//и выдает номер четверти плоскости, в кот находится эта точка

Console.Write("Напишите число X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 && Y == 0)
{
    Console.Write("ВВедите другие данные");
}

else if (X > 0 && Y > 0)
{
    Console.Write("1 четверть");
}

else if (X < 0 && Y < 0)
{
    Console.Write("3 четверть");
}

else if (X < 0 && Y > 0)
{
    Console.Write("2 четверть");
}

else if (X > 0 && Y < 0)
{
Console.Write("4 четверть");
}