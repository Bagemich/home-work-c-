int Prompt(string msg)
{
    Console.WriteLine($"[smg]");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трёхзначное число");
if (number > 100 && number < 1000)
{
    int mid = (number % 100 - number % 10) / 10;
    Console.WriteLine($"Вторая цифра {number} получается {mid}");
}

else
Console.WriteLine("это фигня");