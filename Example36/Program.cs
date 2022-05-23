/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void NewArrayOfNumberRandom(int [] array)
{
Random randomNumber = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(-999,999);
    }
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i !=array.Length-1)
        {
            Console.Write(", ");
        }
    }
  Console.Write("]");
}
int SumElementArray(int [] array)
{
    int result = 0;
    for (var i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
    }
    return result;
}
Console.Write("Введите размер массива: ");
int sizeArray=Convert.ToInt32(Console.ReadLine());
int [] RandomArray = new int [sizeArray];
NewArrayOfNumberRandom(RandomArray);
int findSumArray=SumElementArray(RandomArray);
System.Console.Write($" - > {findSumArray}");