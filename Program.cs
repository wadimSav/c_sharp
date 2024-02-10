/* 
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
void questNumber () {
    while(true) {
        Console.WriteLine("Ввведите целое число: ");
        string str = Console.ReadLine()!;
        int number;
        int num = 0;

        if(str == "q") break;
        
        if(int.TryParse(str, out number)){
            for(int i = 0; i < str.Length; i++){
                num += str[i] - '0';
                Console.WriteLine(num);
            }
            if(num % 2 == 0) break;
        }
    }
}

questNumber();