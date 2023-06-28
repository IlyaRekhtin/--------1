// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num) {
    double res = i % 2;
    if (res == 0) {
        Console.Write($"{i} ");
    };
    i++;
};
