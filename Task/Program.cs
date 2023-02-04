// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. при решение не рекомендуется
// пользоваться колекциями, лучше обойтись исключительно массивами.

string[] array = new string[6] {"hello", "day", "bye", "night", "31", "1995"};
string[] newarray = new string[array.Length];

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for ( int i = 0; i < array1.Length;i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count ++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

NewArray(array, newarray);
PrintArray(newarray);

