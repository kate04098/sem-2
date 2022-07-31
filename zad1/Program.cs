System.Random numberSintezator = new Random();
int number = numberSintezator.Next(10,100);
Console.WriteLine(number);

     //Вариант 1
void variant1 ()
{
     
     int firstNumber = number/10;
     int secondNumber = number%10;
     if(firstNumber>secondNumber)
{
Console.WriteLine(firstNumber);
}
else
{
Console.WriteLine(secondNumber);
}
}
     //Вариант 2
void variant2 ()
    
    {  int numberKirilla = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(numberKirilla);
    String stringNum = numberKirilla.ToString();
    Console.Write("The biggest digit is : ");
    if (stringNum[0] > stringNum[1]){
    Console.WriteLine(stringNum[0]);
    } else {
     Console.WriteLine(stringNum[1]);
     }
    }
     //Вариант 3 
void variant3 ()
{
Char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

}
