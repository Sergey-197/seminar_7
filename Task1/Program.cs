// Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы
//  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//  M = 4; N = 8 -> "4, 5, 6, 7, 8"


 static extern int NumberInTerminal(int numberDigits, string repeatString, int minValueSet);
 {
 string firstText = "Введите значение М => ";
 System.Console.Write(firstText);
 int firstNumber = NumberInTerminal(0,firstText, 1);
 string secondText = "Введите значение N => ";
 System.Console.Write(secondText);
 int secondNumber = NumberInTerminal(0, secondText, 1);
 System.Console.WriteLine($"Числа от {firstNumber} до {secondNumber} => {ShowDigit(firstNumber, secondNumber)}");

   string ShowDigit(int firstDigit, int secondDigit)
{
    if (firstDigit > secondDigit)
    {
        return "";
    }
    return $"{firstDigit} " + ShowDigit(firstDigit + 1, secondDigit);
}
string? numString = Console.ReadLine();
int numInt = 0;
    int minValueSet = 0;
    int numberDigits = 0;
    while ((!Int32.TryParse(numString, out numInt))
        || !(numInt >= minValueSet)
        || !(numInt <= numberDigits))
 { 
        bool repeatString = false;
        System.Console.Write(repeatString);
    numString = Console.ReadLine();
}
return numInt;
}      
