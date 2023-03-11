// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите  число");
int a = Convert.ToInt32(System.Console.ReadLine());
int count = 2;

while (count <= a)
{
    if(count%2==0);
    System.Console.Write(count + " ");
    count+=2;
}
     


