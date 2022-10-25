// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    int[]arr = FillArray(5);
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine(PosNums(arr));
}


int[] FillArray(int coutNumb)
{
    int[]array = new int[coutNumb];
    for (int i = 0; i < coutNumb; i++)
    {
        Console.WriteLine($"Введите число №{i} ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int PosNums(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Main();