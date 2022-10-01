// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//ввод количества элементов
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//задаем массив  
double[]InitArray(int demension)
{
    double[]arr = new double[demension];
    for (var i = 0; i < demension; i++)
    {
        Console.Write($"Элемент № {i+1} : ");
        arr[i] = double.Parse(Console.ReadLine() ?? "");
    }
    return arr;
}

//задаем рандомный массив со значениями от -100 до 100 
/*double[] InitArray(int demension)
{
    double[] arr = new double[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}
*/
//вывод массив на экран в строчку через пробел 
void PrintArray(double[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//main
Console.Clear();
int ardemension = ReadData("Введите количество элементов массива: ");
double[] arr = InitArray(ardemension);
PrintArray(arr);
double max = 0;
double min = 100;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
double razmaxmin = max - min;
string fool = System.String.Empty;
Console.WriteLine(fool);

Console.WriteLine($"Максимальный элемент в массиве : {max.ToString()}");
Console.WriteLine($"Минимальный элемент в массиве : {min.ToString()}");
Console.WriteLine($"Разность между максимальным и минимальным элементом в массиве : {razmaxmin.ToString()}");
