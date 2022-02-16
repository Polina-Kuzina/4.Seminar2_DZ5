// 34. Написать программу замену элементов массива на противоположные
int[] array = new int [8];
Console.WriteLine("Исходный массив");
for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(-100, 101);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine("\nМассив с противоположными элементами");
for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i]+" ");
}
Console.WriteLine();