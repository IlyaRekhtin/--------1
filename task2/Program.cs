// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число для проверки его на четность: ");
int num1 = Convert.ToInt32(Console.ReadLine());
double res = num1 % 2;
if (res == 0) {
    Console.Write($"Число {num1} - четное");
} else {
    Console.WriteLine($"Число {num1} - нечетное");
};