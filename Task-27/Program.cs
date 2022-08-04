
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Enter your number: ");
//int number = int.Parse(Console.ReadLine());
string num = Console.ReadLine();
int number = int.Parse(num);
int[] myArray = new int[num.Length];
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (number != 0)
    {
        myArray[i] = number % 10;
        number = number / 10;
    }

}
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
for (int i = 0; i < myArray.Length; i++)
{
    sum = sum + myArray[i];
}
Console.Write("\nSum of numbers = "+ sum);
