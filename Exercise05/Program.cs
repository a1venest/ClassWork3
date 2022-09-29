// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// int i = 0;

// while (i < array.Length)
// {

//     int number = new Random().Next(0, 2);
//     Console.Write(" [" + number + "] ");
//     i++;
// }

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" " + arr[i] + " ");
    }
}

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

int[] array1 = new int[] {1,2,3,4,5};
int[] array2 = array1;
array1[0] = 5;

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);