//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
double m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double b = Convert.ToInt32(Console.ReadLine());

if(m > b)
    Console.WriteLine("Первое число больше, а второе меньше");
if(b > m)
    Console.WriteLine("Второе  число больше, а первое меньше");
else
    Console.WriteLine("Числа равны");