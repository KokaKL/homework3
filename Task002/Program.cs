// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}

int number = InputInt("Введите число ");

int sum(int num)
{
    int result = 0;
    while (num != 0)
    {
        int N = num % 10;
        result = result + N;
        num = num / 10;
    }
    return result;
}

int SUM = sum(number);
System.Console.WriteLine(SUM);