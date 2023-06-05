// ЗАДАНИЕ 1. напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2=num*num;
// Console.WriteLine(num2); 
//-----------------------------------------------------------------------------

// ЗАДАНИЕ 2. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num==num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// ----------------------------------------------------------------------------


// ЗАДАНИЕ 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (num==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (num==3)
// {
//     Console.WriteLine("Среда");
// }
// else if (num==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (num==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (num==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (num==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня нет");
// }

// --------------------------------------------------------------------


// ЗАДАНИЕ 5. Напишите программу, которая на вход
// принимает одно число (N), а на выходе
// показывает все целые числа в промежутке
// от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4,"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int negNumber= -1*num;
while(negNumber<=num)
{
    Console.Write(negNumber+" ");
    negNumber=negNumber+1;
}

// -------------------------------------------------------------

// ЗАДАНИЕ 7. Напишите программу, которая принимает на вход 
// трехзначное числоо и на выходе показывает последнюю цифру этого числа
// 456 -> 6      782-> 2    918 -> 8 
// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());
// if ((num>99)&&(num<1000))
// {
// int num2=num%10;
// Console.WriteLine(num2);
// }
// else
// {
//     Console.WriteLine("Ошибка");
// }
// *
// /
// +
// -
// % 25/5=5
