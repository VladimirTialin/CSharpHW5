/*
Задача   34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


void addNumberOfArray (int [] array)
{
try
{
    Console.WriteLine("Введите любое трехзначное число:\nДля завершения ввода нажмите Enter");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(System.Console.ReadLine());
            if(array[i]>99 && array[i]<1000)
            {
                Array.Resize(ref array,array.Length + 1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка! Вы попытались ввести число, которое < 100 или > 1000. Повторите ввод!");
                Console.ResetColor();
                break;
            }
        }
}
catch
{
   // При возникновении исключения, когда введено значение отличное от типа данных int, уменьшаем массив на единицу и выводим его
    Array.Resize(ref array,array.Length-1);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}  
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] % 2 == 0 && array[i]>0)
            {
                result++;
        }    
    } 
    if (result!=0)
    {
    Console.Write($"-> {result}");
    }
}

int [] RandomNumbers = new int [1];
addNumberOfArray(RandomNumbers);