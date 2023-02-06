/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/




int [] GetArray(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    char[] separators = new char[] { ' ', '.', ',', '_' };
    int[] arr = text.Split(separators).Select(n => Convert.ToInt32(n)).ToArray();

    return arr;
   
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

}

void GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum++;
    }
    Console.Write($" -> Введено {sum} числа(ел) больше 0");
}

int [] array = GetArray("введите числа в массив  и нажмите Enter");
PrintArray(array);
GetSum(array);