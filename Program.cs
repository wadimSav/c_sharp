/* 
Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)
*/

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 301); // [100, 999]
    return array;
}

void expandArr (int[] array) {
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    int tmp;
    for (int i = 0; i < array.Length / 2; i++){
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
}

expandArr(inputArray(array));