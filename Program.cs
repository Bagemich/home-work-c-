int Prompt(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = ("Это не день недели");
string check(int number)
{
if (number >= 6 && number < 9) ss = "Это выходной";
if (number >= 1 && number < 6) ss = "Это будни";
return ss;
}
Console.WriteLine(check(number));

