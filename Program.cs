/*Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int Prompt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());    
}

string[] GetArray1(int size)
{
    string[] strs = new string[size];
    for (int i = 0; i < strs.Length; i++)
    {
        Console.Write($"Введите строку{i+1} : ");
        strs[i] = Console.ReadLine()!;
    }
    return strs;
}

string[] GetArray2(string[] array)
{
    string[] strs = new string[array.Length];
    int count = 0;
    for (int i = 0; i < strs.Length; i++)
    {
        if (array[i].Length <=3)
        {
            strs[count] = array[i];
            count++;
        }
    }
    string[] str = new string[count];
    for (int i = 0; i < count; i++)
        str[i] = strs[i];
    return str;
}

void PrintArray(string[] array)
{
   Console.Write("[");
   for (int i=0; i<array.Length; i++)
   {
    Console.Write('"'+$"{array[i]}"+'"');
    if (i<array.Length-1) 
        Console.Write(", ");
   }
   Console.Write("]");
    return;
}

int sizeArray = Prompt("Сколько будет строк? - ");
string[] array1 = GetArray1(sizeArray);
string[] array2 = GetArray2(array1);
PrintArray(array1);
Console.Write(" -> ");
PrintArray(array2);
