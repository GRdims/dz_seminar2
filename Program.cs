// Домашняя работа (не решать через свойства строки)
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1
// 

// int number = new Random().Next(100, 999 + 1);
// Console.WriteLine(number);
// int num2 = number / 10 % 10;

// Console.WriteLine(num2);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int num3 = 0;

// if (number < 100){
//     Console.WriteLine($"Третьей цифры нет");
// }
// else
// {

// if ((number > 100) && (number < 1000)){
//     num3 = ((number%100)%10);}

// if ((number >= 1000) && (number < 10000)){
//     num3 = ((number%100)/10);}

// if ((number >= 10000) && (number < 100000)){
//     num3 = ((number/100)%10);}
    
// Console.WriteLine($"Третья цифра числа {number} будет {num3}");
// }


// ​
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Ввести номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number < 1) || (number > 7)){
//     Console.WriteLine("нет такого дня недели");
// }
// else{
    
// if ((number>=1) && (number<=5)){
//     Console.WriteLine("будний день");}
   
// if ((number>=6) && (number<=7)){
//     Console.WriteLine("выходной день");}
// }