// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.



int[] array = new int[10];
int count = 0;
for (int i =0; i<10; i++)
{
     array[i] = new Random().Next(10, 90);
            Console.Write(array[i] + " ");

}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
   if(array[i]%2==0)   
    count++;
}

 Console.Write(count);