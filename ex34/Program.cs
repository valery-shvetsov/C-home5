// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//задаем рандомный массив со значениями от -9 до 9 
int[] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}
//вывод массив на экран в строчку через пробел 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//поиск четных чисел в массиве
int Counteven(int[] array)
{
    int counteven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counteven++;
        }
    }
    return counteven;
}
//ввод количества элементов
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//main
Console.Clear();
int ardemension = ReadData("Введите количество элементов массива: ");
int[] arr = InitArray(ardemension);
PrintArray(arr);
int counteven = Counteven(arr);
string fool = System.String.Empty;
Console.WriteLine(fool);
Console.WriteLine($"Количество четных элементов в массиве : {counteven}");


