// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}

int res = 1;
int A = InputInt("Введите число А");
int B = InputInt("Введите число B");
for (int i = 0; i < B; i++)
{
    res = res * A;
    
}
System.Console.WriteLine(res);
