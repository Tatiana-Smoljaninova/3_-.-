// Написать прогр, кот принимает на вход координаты двух точек и находит расстоян
// между ними в 2D пространстве
//А(3,6); B (2,1); -> 5,09
//А(7,-5); B (1,-1); -> 7,21

Console.Write("Установите значение X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Установите значение Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Установите значение X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Установите значение Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

int X3 = Math.Abs(X1-X2); // длина катета X
int Y3 = Math.Abs(Y1-Y2); // длина катета y
double Z = Math.Sqrt(Math.Pow(X3, 2) + Math.Pow(Y3, 2));  // длина гипотинузы
Console.Write(Z);

// Math.Round