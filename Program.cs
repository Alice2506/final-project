// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна трем символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма.

Console.WriteLine("Введите количество строк массива: ");
int size = int.Parse(Console.ReadLine());
string[] arrayOne = new string[size];
Console.WriteLine("Введите данные: ");
for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = Console.ReadLine();
}
string[] resultArray = new string[arrayOne.Length];
void GetResultArray(string[] arrayOne, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        resultArray[count] = arrayOne[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine("Результат сортировки введенного массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}
GetResultArray(arrayOne, resultArray);
PrintArray(resultArray);

