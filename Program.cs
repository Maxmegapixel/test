// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] massive = GetArray();
Console.WriteLine($"Массив: [{String.Join(", ", massive)}]");
Console.WriteLine($"Новый: [{String.Join(", ", GetNew(massive))}]");

string[] GetArray()  // метод для ввода массива
{
    Console.Write("Введите количество элементов массива: ");
    int number = int.Parse(Console.ReadLine()!);
    string[] result = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        result[i] = Console.ReadLine()!;
    }
    return result;
}

// метод для формирования нового массива
string[] GetNew(string[] array)
{
    string temp = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) temp += array[i]+" "; 
    }
    string[] result = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return result;
}

