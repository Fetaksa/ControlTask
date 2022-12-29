// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = new string[] { "Hi", "I", "am", "late", "as", "usual" };
string[] newArray = new string[array.Length];

void ThreeDigitsOrLess(string[] firstArray, string[] secondArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[j] = firstArray[i];
            j++;
        }

    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ThreeDigitsOrLess(array, newArray);
PrintArray(newArray);