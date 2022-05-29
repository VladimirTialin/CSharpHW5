/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
//Функция заполнения массива автоматически
double[] ArrayRandomNumbers(double [] ArrayNumbers, int Factor)
{
    var RandomNumbers = new Random();
    for (var i = 0; i < ArrayNumbers.Length; i++)
    {
        ArrayNumbers[i] = Math.Round(RandomNumbers.NextDouble()*Factor,2);
    }
    return ArrayNumbers;
}
//Функция заполнения массива вручную
double[] ArrayNumbers(double [] ArrayNumbers)
{
    Console.WriteLine($"\nВведите {ArrayNumbers.Length} любых чисел: ");
    for (var i = 0; i < ArrayNumbers.Length; i++)
    {
        ArrayNumbers[i] = Convert.ToDouble(Console.ReadLine());
    }
    return ArrayNumbers;
}
//Функция разници Max и Min значения
double ArrayRealNumber(double[] ArrayNumbers)
{
    double Max=ArrayNumbers[0];
    double Min=Max;
    for (var i = 0; i < ArrayNumbers.Length; i++)
    {
        if(ArrayNumbers[i]>Max)
        {
            Max=ArrayNumbers[i];
        }
        else if(ArrayNumbers[i]<Min)
        {
            Min=ArrayNumbers[i];
        }
    }
    double result=Max-Min;
    return result;
}
//Функция вывода массива
void PrintArray(double [] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(" | ");
        }
    }
    Console.Write("]");
}
//Ввод данных
double [] ResultArray;
double result;
Console.Write("Задайте размер массива: ");
int size=Convert.ToInt32(Console.ReadLine());
var ArrayNumber= new double [size];
Console.Write("\nЗаполним массив вручную? Нажмите клавишу Y/N: ");
ConsoleKeyInfo press=Console.ReadKey();
if (press.Key==ConsoleKey.Y)
{
    ResultArray = ArrayNumbers(ArrayNumber);
    PrintArray(ResultArray);

}
else
{
    Console.Write("\nМассив сформируется автоматически!\nВведите любое число для формирования диапазона значений: ");
    int Factor=Convert.ToInt32(Console.ReadLine());
    ResultArray = ArrayRandomNumbers(ArrayNumber,Factor);
    PrintArray(ResultArray);
}
result=ArrayRealNumber(ResultArray);
Console.WriteLine(" -> "+result);