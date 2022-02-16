// 40. В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
double[] array = new double [10];
Console.WriteLine("Массив");
for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().NextDouble();
    Console.WriteLine(array[a]+" ");
    
}
double maxNumber = array[0];
double minNumber = array[0];
for(int i = 1; i < array.Length; i++)
{
    if (array[i] > maxNumber)  maxNumber = array[i];
        else if (array[i] < minNumber) minNumber = array[i];
}
Console.WriteLine("Максимальное число массива = " + maxNumber);
Console.WriteLine("Минимальное число массива = " + minNumber);
Console.WriteLine("Разница между маскимальным и минимальным числами = " + (maxNumber-minNumber));