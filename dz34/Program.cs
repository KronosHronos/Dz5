Console.Clear();

int length  = GetUserNumber("Введите размер: ", "Ошибка ввода!");                              
int[] userArray = GetArrayRandom(length);
int count = Count(userArray);

Console.Write($"{String.Join(" ", userArray)} -> {count } четных в массиве");

int Count(int[] array)
{
    int count  =0;
    foreach(int el in array)
        {
            if(el%2==0) count +=1;
        }
    return count ;

}

int[] GetArrayRandom(int inputLenght)
{
    int[] randomArray = new int[inputLenght];
    for(int i=0; i<inputLenght; i++)
    {
        randomArray[i] = new Random().Next(100, 999);
    }
    return randomArray;
}

int GetUserNumber(string messageToUser, string errorMessage)
{
        while(true)
        {
            Console.Write(messageToUser);
            if(int.TryParse(Console.ReadLine(), out int userNumber))
                return userNumber;
            Console.WriteLine(errorMessage);
        }
}
