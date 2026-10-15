// // // // // // // // // задние 1.1

// // // // // // // // for (int i = 10; i >= 1; i--)

// // // // // // // // {
// // // // // // // //     Console.Write(i + " ");
// // // // // // // // }

// // // // // // // //задание 1.2
// // // // // // // for (int i = 2; i <= 50; i += 2)
// // // // // // // {
// // // // // // //     Console.Write(i + " ");
// // // // // // // }



// // // // // // //задание 2
// // // // // // int sum = 0;
// // // // // // int count_7 = 0;
// // // // // // for (int i = 1; i <= 100; i++)
// // // // // // {
// // // // // //     if (i % 3 == 0)
// // // // // //     {
// // // // // //         sum += i;
// // // // // //     }
// // // // // //     if (i % 7 == 0)
// // // // // //     {
// // // // // //         count_7++;
// // // // // //     }
// // // // // // }
// // // // // // Console.WriteLine($"сумма чисел кратных 3 - {sum} кол-во чисел которые делятся на 7 -  {count_7}");



// // // // // //задание 3
// // // // // using System.Globalization;

// // // // // int number = Convert.ToInt32(Console.ReadLine());
// // // // // int count_pl = 0;
// // // // // int count_mn = 0;
// // // // // while (number != 0)
// // // // // {
// // // // //     if (number > 0)
// // // // //     {
// // // // //         count_pl++;
// // // // //     }
// // // // //     if (number < 0)
// // // // //     {
// // // // //         count_mn++;
// // // // //     }
// // // // //     number = Convert.ToInt32(Console.ReadLine());

// // // // // }
// // // // // Console.WriteLine($"количество положительных чисел  {count_pl} количество отрицательных чисел {count_mn}");



// // // // //задние 4
// // // // string password;
// // // // int count = 0;

// // // // do
// // // // {
// // // //     Console.Write("введите пароль\n");
// // // //     password = Console.ReadLine();
// // // //     if (password == "qwerty")
// // // //     {
// // // //         Console.Write("Доступ Разрешен");
// // // //         return;
// // // //     }
// // // //     count += 1;


// // // // }
// // // // while (password != "qwerty" && count < 3);
// // // // Console.WriteLine("Количество попыток превысило 3");



// // // // // задание 5
// // // Console.WriteLine("Введите число от 1 до 10");
// // // int n = Convert.ToInt32(Console.ReadLine());
// // // for (int i = 1; i <= 10; i++)
// // // {
// // //     Console.Write($"{n} x {i} = {n * i}\n");
// // // }

// // // задание 6

// // for (int i = 1; i <= 30; i++)
// // {
// //     if (i % 3 == 0) continue;
// //     if (i % 10 == 0 && i > 20)
// //     {
// //         break;
// //     }
// // }

// Итоговое задание
// int random_c = 32;
// int a;
// int count = 0;
// do
// {
//     a = Convert.ToInt32(Console.ReadLine());
//     if (a > random_c)
//     {
//         Console.Write("меньше\n");
//     }
//     if (a < random_c)
//     {
//         Console.Write("больше\n");
//     }
//     if (a == random_c)
//     {
//         Console.Write($"победа! попыток {count}\n");
//         return;
//     }
//     count++;
// }
// while (count < 5);
// Console.WriteLine("число попыток превысило 5\n");
// return;
