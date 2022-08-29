//\\ Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();
// Console.Write("Введите координату пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99999 || num < 10000)
// {
// Console.Write("Введено неверное число");
// }
// else if (num / 10000 != num % 10 )
// {
//     Console.Write("Введенное число не является палиндромом");
// }
// else if ((num / 1000) %10 != (num % 100) / 10)
// {
//     Console.Write("Введенное число не является палиндромом");
// }
// else
// {
//     Console.Write($"Число {num} является палиндромом");
// }



//\\ Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// Console.Clear();
// Console.Write("Введите координату X1: ");
// double numX = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// double numY = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// double numZ = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X2: ");
// double numX2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// double numY2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z2: ");
// double numZ2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Дистанция между точкой А({numX}, {numY}, {numZ}) и точкой В({numX2}, {numY2}, {numZ2}) = " );
// Console.Write(Math.Round(Math.Sqrt(Math.Pow((numX2 - numX), 2) + Math.Pow((numY2 - numY), 2) + Math.Pow((numZ2 - numZ), 2)), 2));


//\\ Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N, что бы вывести таблицу кубов чисел от 1 до N: ");
int num=Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= Math.Abs(num))
{
Console.Write($"{Math.Pow(count++, 3)}, ");
}