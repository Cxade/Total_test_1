/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не реккомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] FillArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] ThreeSymbols(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }
    string[] new_arr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            new_arr[j] = arr[i];
            j++;
        }
    }
    return new_arr;
}


Console.WriteLine("Сколько объектов вы собираетесь ввести?");
int size = int.Parse(Console.ReadLine());
string[] arr = FillArray(size);
Print(arr);
string[] new_arr = ThreeSymbols(arr);
Console.WriteLine("Объекты с 3 или меньше символами:");
Print(new_arr);