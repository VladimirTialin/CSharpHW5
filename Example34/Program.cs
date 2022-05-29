/*
Задача   34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//Функция ввода данных в массив через Array.Resize
int [] AddNumberOfArray (int [] array)
{
try
{
    Console.WriteLine("Введите любое трехзначное число:\nДля завершения ввода нажмите Enter");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(System.Console.ReadLine());
        Array.Resize(ref array,array.Length + 1);
    }
}
catch
{
// При возникновении исключения, когда введено значение отличное от типа данных int, уменьшаем массив на единицу и выводим его
Array.Resize(ref array,array.Length-1);
} 
return array;
} 
bool Error(int[] array)
{
    bool Error=true;
    for (var i = 0; i < array.Length; i++)
    {
       if(array[i]<99 || array[i]>1000)
       { 
        Error=false;
        break;  
       }   
    }
    return Error;
}
//Функция вывода массива
void PrintArray(int [] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int EvenNumberOfArray(int[] array)
{
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
    return result;
    }
    return 0; 
}
int [] Numbers = new int [1];
int result;
int [] ResultArray=AddNumberOfArray(Numbers);
bool ShowError = Error(ResultArray);
if(ShowError==true)
{
    PrintArray(ResultArray);
    result=EvenNumberOfArray(ResultArray);
    Console.Write($"-> {result}");    
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибка! Вы попытались ввести число, которое < 100 или > 1000. Повторите ввод!");
    Console.ResetColor();
}