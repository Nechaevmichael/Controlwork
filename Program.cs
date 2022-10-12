string[] array = {"Russia", "2", "world", ":-)", "-2", "3", "12", "Git"};

// int i = 0;
// while (i < array.Length)
// {
//     if (array[i].Length <= 3) Console.Write($"{array[i]} ");
//     i += 1;
// }

string[] CreateArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count += 1;
        }
    }
    string[] array = new string[count];
    {
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) 
            {
                array[j] = arr[i];
                j += 1;
            }
        }
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
// {
//     string[] result = new string[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i].Length <= 3) result[i] = arr[i];
//     }
//     return result;
// }

// void PrintArray(string[] arr)
// {
//     int count = arr.Length;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i == count - 1) Console.Write($"{arr[i]}]");
//         else 
//         {
//             if (arr[i] != default) Console.Write($"{arr[i]}, ");
//         }
//     }
// }
string[] arrayResult = CreateArray(array);
PrintArray(arrayResult);