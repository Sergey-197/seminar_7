//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


    int[] numbers = { 1, 2, 5, 0, 10, 34 };
    int temp;

    Console.Write("произвольный массив: ");

    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
    Console.Write("\nПеревернутый массив: ");
   foreach (int number in numbers)
   {
       Console.Write(number + " ");
   }

















// static int[] CreateArray()
//  {
//     int[] array = CreateArray();
//     System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
//     System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");
//     int size = int.Parse(Console.ReadLine());

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100,);
//         Console.WriteLine(array);
//         {
//             if(size <= 0)
//     {
//         return array;
//     }
//      PrintCreateArray(int[]array)
//      Console.WriteLine(int[]array);
//      {
// {


    
     
    
    
    
     
 



