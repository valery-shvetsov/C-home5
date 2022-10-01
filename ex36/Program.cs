// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//ввод количества элементов
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//задаем рандомный массив со значениями от -9 до 9 
int[] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-100, 100);
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
//main
Console.Clear();
int ardemension = ReadData("Введите количество элементов массива: ");
int[] arr = InitArray(ardemension);
PrintArray(arr);
int sumnoneven=0;
for (int i = 0; i < arr.Length; i+=2)
{
sumnoneven=sumnoneven+arr[i];
}
string fool = System.String.Empty;
Console.WriteLine(fool);

Console.WriteLine($"Сумма элементов на нечетных позициях в массиве : {sumnoneven.ToString()}");
