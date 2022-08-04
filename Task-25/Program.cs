
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("\nEnter number B: ");
int b = int.Parse(Console.ReadLine());
int naturalDegree = 1;

int[] myArray = Enumerable.Repeat(a, b).ToArray();

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
for (int i = 0; i < myArray.Length; i++)
{
    naturalDegree = naturalDegree * myArray[i];
}
Console.Write("\nNatural degree = " + naturalDegree);
