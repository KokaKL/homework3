// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}
int n = InputInt("Введите максимально значение для массива");
System.Console.WriteLine();
int random()
{
    int number = new Random().Next(1, n+1);
    System.Console.WriteLine(number);
    return number;
}

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, n);
}
System.Console.WriteLine($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");
System.Console.WriteLine();
