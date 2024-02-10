/* 
Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
    return array;
}

void countEvenNumbers (int[] array) {
    int count = 0;
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    foreach (int element in array){
        if (element % 2 == 0)
            count++;
    }
    Console.WriteLine(count);
}

countEvenNumbers(inputArray(array));