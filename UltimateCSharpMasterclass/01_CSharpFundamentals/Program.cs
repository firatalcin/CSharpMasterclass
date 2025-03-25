//Variables

string name = "Nisha";
int number;
number = 5;
number = 10;
Console.WriteLine(number);

//Naming Variables

//string class = "First"; // keywords'ler değişken ismi olamazlar
string @class = "First";
int _number = 10;
int also_some_number = 5;
int alsoSomeNumber = 5;
//int 1number = 1; // değişken isimleri sayı ile başlayamaz
string name1 = "Anna";
int age, Age;

//Operators

int sum = 5 + 10;
int resultNoParenthesis = 5 + 2 * 3;
int resultParenthesis = 5 + (2 * 3);
var stringAndInt = "abc" + 5;

//Implicity Typed Variables

string word1 = "text";
var word2 = "text";
//var invalidVariables; // var kullanılırken ilk değer değişken tanımlanırken verilmelidir.

// Comments

// Tek satır comment

/*
 
Çoklu
Satır 
Comment
 
 */

//Boolean Type

Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();
bool isUserInputAbc = userInput == "ABC";
bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC");
var isLargerThan5 = number > 5;
var isSmallerThan10 = number <= 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;
var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = number % 2 == 0;
var isOdd = number % 2 != 0;

var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 =
    number == 2 || number > 6 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 =
    number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 5; 
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0;

//if/else statements

if (userInput.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if (userInput.Length < 10)
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}

//Scopes

if (userInput.Length == 0)
{
    Console.WriteLine("Empty choice");
    var word = "ABC";
    int someNumber = 5;
    if (word.Length > 0)
    {
        Console.WriteLine(someNumber); 
    }
}
else
{
    int someNumber = 6; 
    Console.WriteLine("Your choice is: " + userInput);
    Console.WriteLine(someNumber); 
}
Console.WriteLine("Your choice is: " + userInput);

