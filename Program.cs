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

// Console.Write("введите координату X: ");
// int numX = int.Parse(Console.ReadLine()!);
// Console.Write("введите координату Y: ");
// int numY = int.Parse(Console.ReadLine()!);
// if (numX != 0 && numY != 0) {
//     if (numX > 0 && numY > 0) {
//         Console.Write("Номер координатной четверти равен 1");
//     } else if (numX < 0 && numY > 0) {
//         Console.Write("Номер координатной четверти равен 2");
//     } else if (numX < 0 && numY < 0) {
//         Console.Write("Номер координатной четверти равен 3");
//     } else if (numX > 0 && numY < 0) {
//         Console.Write("Номер координатной четверти равен 4");
//     }
// } else {
//     Console.Write($"{numX} и {numY} не должны быть равны 0");
// }

/* 
Задача 3: Напишите программу, которая принимает на вход целое число из отрезка
 [10, 99] и показывает наибольшую цифру числа.
 */

// Console.Write("Введите целое число от 10 до 99 включительно: ");
// int in_num = int.Parse(Console.ReadLine()!);
// if (in_num < 10 || in_num > 99) {
//     Console.WriteLine("Ваше число не входит в заданый диапазон");
// } else {
//     int first_num = in_num / 10;
//     int second_num = in_num % 10;
//     if (first_num > second_num) {
//         Console.WriteLine($"{first_num} первая цифра больше");
//     } else if (first_num < second_num) {
//         Console.WriteLine($"{second_num} вторая цифра больше");
//     } else {
//         Console.WriteLine($"{second_num} и {first_num} равны");
//     }
// }

/* 
Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
 */

Console.Write("Введите натуральное число: ");
int n_num = int.Parse(Console.ReadLine()!);
if (n_num > 0) {
    int count = 1;
    while(count <= n_num) {
        if (count != n_num)
            Console.Write($"{count}, ");
        else
            Console.Write($"{count}");
        count++;
    }
} else {
    Console.WriteLine("Вы ошиблись при вводе числа. \n Попробуйте еще раз");
}