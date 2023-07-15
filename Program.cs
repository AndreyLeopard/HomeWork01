


/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*
void Task2()
{
    Console.WriteLine("Введите первое число a:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число b:");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine($"{a} наибольшее");
        Console.WriteLine($"{b} наименьшее");
    }
    else if (a < b)
    {
        Console.WriteLine($"{b} наибольшее");
        Console.WriteLine($"{a} наименьшее");
    }
    else
    {
        Console.WriteLine($"Числа равны");
    }

} 
Task2(); */
/*
void Task2()
{
 Console.WriteLine("Введите первое число a:");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе число b:");
 int b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
 {
 Console.WriteLine("Максимальное число: " + a + " Минимальное число: " + b);
 }

 else if (b > a)
 {
 Console.WriteLine("Максимальное число: " + b + " Минимальное число: " + a);
 }
}
Task2();*/

/* void Task4()
{
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число:");
    int c = Convert.ToInt32(Console.ReadLine());

     int max = a;

    if (max < b) 
    {
        max = b;
    }
    
    if (max < c)
    {
        max = c;
    }

    Console.WriteLine($"Наибольшее число: {max}");
   
}

Task4();
*/

/* Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

 if (Max = a > b; max > c)
{
Console.WriteLine("Максимальное число: " + a);
}

else if (Max = a < b; max > c)
{
Console.WriteLine("Максимальное число: " + b);
}

else if (Max = c > b; max > a)
{
Console.WriteLine("Максимальное число: " + с);
}

*/


/*


 /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */
/*
void Task6()
{
    int number = Input ("Введите число: ");

    if (number % 2 == 0) Console.WriteLine($"Число {number} четное");
    else Console.WriteLine($"Число {number} Нечётное");
}   
Console.Clear();
Task6(); */

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
void Task8()
{
    int number = Input("Введите число: ");
    
    int counter = 2;

    while (counter <= number)
    {
        Console.Write ($"{counter} ");
        counter += 2;
    }
    Console.WriteLine();
}

Console.Clear();
TaskAsyncEnumerableExtensions();
*/