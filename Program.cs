/* 
Задача 1: Напишите программу, которая принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
 */

// Console.Write("введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num / 7 == 23 && num / 23 == 7) {
//     Console.Write($"{num} кратно 7-ми и 23-м");
// } else {
//     Console.Write($"{num} не кратно 7-ми и 23-м");
// }

/* 
Задача 2: Напишите программу, которая принимает на вход координаты 
точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
 в которой находится эта точка.
 */

Console.Write("введите координату X: ");
int numX = int.Parse(Console.ReadLine()!);
Console.Write("введите координату Y: ");
int numY = int.Parse(Console.ReadLine()!);
if (numX != 0 && numY != 0) {
    if (numX > 0 && numY > 0) {
        Console.Write("Номер координатной четверти равен 1");
    } else if (numX < 0 && numY > 0) {
        Console.Write("Номер координатной четверти равен 2");
    } else if (numX < 0 && numY < 0) {
        Console.Write("Номер координатной четверти равен 3");
    } else if (numX > 0 && numY < 0) {
        Console.Write("Номер координатной четверти равен 4");
    }
} else {
    Console.Write($"{numX} и {numY} не должны быть равны 0");
}