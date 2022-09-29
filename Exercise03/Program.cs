// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int ImputNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigCount(int Number)
{
    // string Numbers()
    // {
    //     string numbers = Convert.ToString(num);
    //     return numbers;
    // }
    int DigCount = 0;
    // Number = Math.Abs(Number / 10);
    while (Number > 0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}

Console.WriteLine("Количество цифр в числе = " + GetDigCount(ImputNumber()));
