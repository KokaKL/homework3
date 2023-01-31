// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}
int A = InputInt("Введите число А");
int B = InputInt("Введите число B");
double res = 1;
double a = 1;

if(B >= 0)
{
for (int i = 0; i < B; i++)
{
    res = res * A;
}
}
else
{
   for (int y = 0; y < (B*(-1)); y++)
{
    a = a * A;
    res = 1/a;
} 
}
System.Console.WriteLine(res);

