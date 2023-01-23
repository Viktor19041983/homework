int num = new Random().Next(10, 100);
int numA = num / 10;
int numB = num % 10;
int max = numA;
if (max < numB)
{
    max = numB;
}
Console.WriteLine($"В числе {num} наибольшая цифра {max} ");