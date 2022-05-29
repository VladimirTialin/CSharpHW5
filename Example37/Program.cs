/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

Вариант 1

System.Console.Write("Введите числа через пробел: ");
var number=Console.ReadLine()?.Split()?? new string[0];
var NumberList= new List<int>(number.Select(Int32.Parse));
Console.WriteLine($"Вы заполнили массив {NumberList.Count} элементами");
void MultiplicationNumberOfArray(List<int>numbers)
{
    int[] NewArrayNumber;
    int size;
    if (numbers.Count%2==0)
    {
        size=numbers.Count/2;
        NewArrayNumber=new int[size];
        for (int i = 0; i < size; i++)
        {
            NewArrayNumber[i]=numbers[i]*numbers[numbers.Count-1-i];
            Console.Write(" "+NewArrayNumber[i]);
        }
    }
    else
    {
        size=numbers.Count/2+1;
        NewArrayNumber=new int[size];
        for (int i = 0; i < size; i++)
        {
            if(i!=size-1)
            {
                NewArrayNumber[i]=numbers[i]*numbers[numbers.Count-1-i];
                Console.Write(" "+NewArrayNumber[i]);
            }
            else
            {
                NewArrayNumber[i]=numbers[i];
                Console.Write(" "+NewArrayNumber[i]);   
            }
        }
    }
}
MultiplicationNumberOfArray(NumberList);
*/
//Вариант 2 - убрал условие в нечетном массиве
System.Console.Write("Введите числа через пробел: ");
var number=Console.ReadLine()?.Split()?? new string[0];
var NumberList= new List<int>(number.Select(Int32.Parse));
Console.WriteLine($"Вы заполнили массив {NumberList.Count} элементами");
int [] MultiplicationNumberOfArray(List<int>numbers)
{
    int[] NewArrayNumber;
    int size;
    if (numbers.Count%2==0)
    {
        size=numbers.Count/2;
        NewArrayNumber=new int[size];
        for (int i = 0; i < size; i++)
        {
            NewArrayNumber[i]=numbers[i]*numbers[numbers.Count-1-i];
        }
    }
    else
    {
        size=numbers.Count/2+1;
        NewArrayNumber=new int[size];
        for (int i = 0; i < size-1; i++)
        {
            NewArrayNumber[i]=numbers[i]*numbers[numbers.Count-1-i];
        }

            NewArrayNumber[numbers.Count/2]=numbers[numbers.Count/2];  
        }
    return NewArrayNumber;
}
Console.ForegroundColor=ConsoleColor.DarkGreen;
Console.Write("[");
for (var i = 0; i < NumberList.Count; i++)
{
    Console.Write(NumberList[i]);
    if(i!=NumberList.Count-1)
    {
        Console.Write(", ");
    } 
}
Console.Write("] - > ");
int [] result=MultiplicationNumberOfArray(NumberList);
foreach (var i in result)
{
    Console.Write(" "+i);
}
Console.ResetColor();