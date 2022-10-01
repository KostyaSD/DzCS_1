//Домашние задание к 1 семинару, для проверки решения раскоментируйте блок кода заключенный в /**/.

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*while (true) {
    try {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Первое число: " + a + " большее, а второе число " + b + " меньшее");
        }
        else if (b > a)
        {
            Console.WriteLine("Второе число: " + b + " большее, а первое число " + a + " меньшее");
        }
        else Console.WriteLine("Числа: " + a + " и " + b + " равны");
        break;
    }
    catch {
        Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
    }
}*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*while (true) {
    try {
        Console.WriteLine("Введите три числа");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        Console.WriteLine("Максимальное число: " + max);
        break;
    }
    catch {
        Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
    }
}*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Проверка числа на четность, пожалуйста введите число: ");
while (true) {
    try {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 0) Console.WriteLine("0 это четное число (не путать с положительным и отрицательным)");
        else if (num % 2 == 0) {
            Console.WriteLine("Число " + num + " является чётным. Ответ: Да");
            break;
        } else if (num % 2 != 0) {
            Console.WriteLine("Число " + num + " не является чётным. Ответ: Нет");
            break;
        }
    }
    catch {
        Console.WriteLine("Ошибка, пожалуйста повторите ввод: ");
    }
}*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Для того чтобы показать все чётные числа от 1 до N. Введите число N");
while (true) {
    try {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 1) {
            Console.WriteLine("необходимо ввести число больше 1, повторите ввод");
        }
        else {
            Console.WriteLine("Выбран промежуток от 1 до " + n);
            Console.Write("Четные числа: ");
            for (int i = 1; i <= n; i++) {
                if (i % 2 == 0) {
                    Console.Write(i + " ");
                }
            }
        break;
        }
    }
    catch {
        Console.WriteLine("Ошибка, пожалуйста повторите ввод: ");
    }
}*/

