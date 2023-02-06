/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


int Insert(string messege)
{
    System.Console.Write(messege);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}


void GetPoint(double k1, double b1, double k2, double b2)
{

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;


    System.Console.WriteLine($"точка пересечения данных прямых -> ({x},{y})");
}


System.Console.WriteLine("введите данные в формулу (y = k1 * x + b1, y = k2 * x + b2):");
int k1 = Insert("k1=");
int b1 = Insert("b1=");
int k2 = Insert("k2=");
int b2 = Insert("b2=");


GetPoint(k1, b1, k2, b2);