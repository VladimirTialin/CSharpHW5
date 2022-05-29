/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double ArrayRealNumbers(double [] ArrayNumbers, int Factor)
{
    double Max=ArrayNumbers[0];
    double Min=Max;
    var RandomNumbers = new Random();
    for (var i = 0; i < ArrayNumbers.Length; i++)
    {
        ArrayNumbers[i] = Math.Round(RandomNumbers.NextDouble()*Factor,2);
    }
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
Console.Write("Задайте размер массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Массив будет формироваться автоматически!\nВведите любое число для формирования диапазона значений: ");
int Factor=Convert.ToInt32(Console.ReadLine());
double [] ArrayNumber= new double [size];
double result = ArrayRealNumbers(ArrayNumber,Factor);
void PrintArray(double [] array)
{
    Console.Write("[");
    for (var i = 0; i < ArrayNumber.Length; i++)
    {
        Console.Write(i);
        if(i!=ArrayNumber.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArray(ArrayNumber);
 Console.WriteLine(" -> "+result);