Console.Clear();

int length = GetUserNumber("Введите число: ", "Ошибка ввода!");
int[] userArray = GetArrayRandom(length);
int count = Count(userArray);

Console.Write($"{String.Join(" ", userArray)} -> {count}");

int GetUserNumber(string messageToUser, string errorMessage)
{
    while (true)
    {
        Console.Write(messageToUser);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayRandom(int inputLenght)
{
    int[] randomArray = new int[inputLenght];
    for (int i = 0; i < inputLenght; i++)
    {
        randomArray[i] = new Random().Next(-100, 1000); 
    }
    return randomArray;
}

int Count(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}