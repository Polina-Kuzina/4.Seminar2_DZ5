// 38. Найти сумму чисел одномерного массива, стоящих на нечётной позиции. 
int[] array = new int [5];
Console.WriteLine("Массив");
for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(0, 10);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine();
int sumOddNumber = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 > 0)  sumOddNumber = sumOddNumber + array[i];
}
Console.WriteLine("Сумма нечетных элементов массива = " + sumOddNumber);

