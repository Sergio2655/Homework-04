
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArrray = new int[8];
Random point = new Random();
for(int i = 0; i < myArrray.Length; i++)
{
    myArrray[i] = point.Next(0,8);
}
for(int i = 0; i < myArrray.Length; i++)
{
    Console.Write(myArrray[i] + " ");

}