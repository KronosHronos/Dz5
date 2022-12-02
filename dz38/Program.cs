int length = GetUserNumber("Введите число: ", "Ошибка ввода!");
double[] userArray = GetArrayRandom(length);
double result = Difference(userArray);
Console.Write($"{String.Join(" ", userArray)} -> Max-min = {result}");

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNum))
            return userNum;
        Console.WriteLine(errorMessage);
    }
}

double[] GetArrayRandom(int inputLenght)
{
    double[] randomArray = new double[inputLenght];
    for (int i = 0; i < inputLenght; i++)
    {
        randomArray[i] = new Random().Next(-100, 999);  
    }
    return randomArray;
}

double Difference(double[] array)
{
    int maxPosition = 0;
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxPosition])
            maxPosition = i;
        if (array[i] < array[minPosition])
            minPosition = i;
    }
    return array[maxPosition] - array[minPosition];
}