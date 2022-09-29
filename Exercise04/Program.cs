// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int GetNumber()
{
    int num = 0;
    while (num < 1)
    {
        Console.WriteLine("Введите число N (больше 0):");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int GetMultiplication(int number)
{
    int multiplication = 1;

    for (int i = 1; i <= number; i++)
    {
        multiplication = multiplication * i;
    }
    return multiplication;
}

int number = GetNumber();
string mult = Convert.ToString(GetMultiplication(number));
Console.WriteLine("Произведение цифр в данном числе равняется: " + mult);