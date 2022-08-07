// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


int[] Array8 = {1, 2, 5, 7, 19, 22, 77, 69};

void PrintArray (int[] array)
{
   for(int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]+" ");
   }
   Console.WriteLine();
 }
 
PrintArray (Array8);*/

// дубль2
/*
int[] Array8 (int size)

 {
   int[] Array = new int [size];
   for(int i = 0; i < size; i++)
   {
    Console.WriteLine($"{Array[i]}" );
   }
   return Array;

}

Console.WriteLine("Введите 8 натуральных чисел через пробел" );
int number = Convert.ToInt32(Console.ReadLine());

int[] array = Array8 (8);*/

// дубль 3

/*
int[] RandomArray (int size,int minValue,int maxValue )
 {
   int[] Array = new int [size];
   for(int i = 0; i < size; i++)
   {
      Array[i] = new Random().Next(minValue, maxValue);
   }
   return Array;
 }
 void ShowArray(int[]array)
{
   for (int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine( );

}
int[] binaryArray = RandomArray(8, 1, 100);
ShowArray (binaryArray);*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
452 -> 11
82 -> 10
9012 -> 12



int SumOfDigits (int num)
{  int count = 0;
   while(num>0)                   //(num!=0)
   {
      count = count + num%10;
   }
    return count;
}   

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = SumOfDigits (number);
Console.WriteLine($"Сумма всех цифр данного числа =  {summa} ");
//Неработает, непойму почему терминал не выводит результат*/



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int ADegreeB (int A, int B)
{
  int res = 1;
   while(B == 0)
   {
      res = res * A ;
      B = B-1 ;      
   }
return res;
}  
Console.Write("Введите первое положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе положительное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int resalt = ADegreeB(numberA,numberB);
Console.WriteLine(resalt);
// Тут тоже что то не так в оформлении, я по разному пыталась составить, 
//само уровнение прорешивала на бумаге, должно быть верно