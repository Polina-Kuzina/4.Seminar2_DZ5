// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.
int[] array = new int [25];
Console.WriteLine("Массив");
for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(100, 1000);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine();
int evenNumber = 0;
int oddNumber = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)  evenNumber++;
    else oddNumber++;
}
Console.WriteLine("Количество четных чисел = " + evenNumber);
Console.WriteLine("Количество нечетных чисел = " + oddNumber);