// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArrayString(string [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
}

void checkArray(string [] array)
{
    string [] finishArray = Array.Empty<string>();
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) 
        {
            Array.Resize(ref finishArray, finishArray.Length + 1);
            finishArray[finishArray.Length - 1] = array[i];
        }
    }
    PrintArrayString(finishArray);
}


string [] startArray = {"Hello", "2", "world", ":-)"};
checkArray(startArray);

string [] startArray1 = {"1234", "1567", "-2", "computer science"};
checkArray(startArray1);

string [] startArray2 = {"Russia", "Denmark", "Kazan"};
checkArray(startArray2);
