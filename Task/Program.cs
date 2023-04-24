// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray1(string[] arr, int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write("Введите строчное значение: ");
        arr[i] = Console.ReadLine();
    }
}

string[] CreateAndFillArray2(string[] arr, int arrSize1)
{
    int sum = 0;
    int length = 0;
    for (int i = 0; i < arrSize1; i++)
    {
        length = arr[i].Length;
        if (length <= 3)
        {
            sum = sum + 1;
        }
    }
    string[] arr2 = new string[sum];
    int j = 0;
    for (int i = 0; i < arrSize1; i++)
    {
        length = arr[i].Length;
        if (length <= 3)
        {
            arr2[j] = arr[i];
            j++;
        }
    }
    return arr2;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


Random R = new Random();
int Size1 = R.Next(0, 10);
string[] arrayLong = new string[Size1];
FillArray1(arrayLong, Size1);
PrintArray(arrayLong);

string[] arrayShort = CreateAndFillArray2(arrayLong, Size1);
PrintArray(arrayShort);