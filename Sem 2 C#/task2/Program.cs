//Напишите программу, которая выводит случайное трехзначное число
//и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int num = new Random().Next(100, 1000);
int numA = num / 100;
int numB = num % 10;
numA = numA*10;
Console.WriteLine (numA+numB);