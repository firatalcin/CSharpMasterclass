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


//Methods - part 1 - void methods

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

//Methods - part 2 - non-void methods

int Add(int a, int b)
{
    return a + b;
}

bool IsLong(string input)
{
    return input.Length > 10;
}

//Parsing a string to an int

string numberAsText = "123";
int parsedToInt = int.Parse(numberAsText);


//String interpolation

int a = 4, b = 2, c = 10;
Console.WriteLine(
    "First is: " + a + ", second is: " + b + ", third is: " + c);

Console.WriteLine(
    $"First is: {a}, second is: {b}, third is: {c}");

Console.WriteLine(
    $"Sum is: {a + b + c}, second is: {b}, third is: {c}");


//Switch statement

char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}

//Switch expression with contant pattern

char ConvertPointsToGrade_ConstantPattern(int points)
{
    return points switch
    {
        10 or 9 => 'A',
        8 or 7 or 6 => 'B',
        5 or 4 or 3 => 'C',
        2 or 1 => 'D',
        0 => 'E',
        _ => '!',
    };
}

//Switch expression with relational pattern

char ConvertPointsToGrade_RelationalPattern(int points)
{
    return points switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 50 => 'C',
        _ => 'D' //anything below 50 gets a D
    };
}


//While loop

var numberWhileLoop = 0;
while (numberWhileLoop < 10)
{
    numberWhileLoop += 1;
    Console.WriteLine("Number is: " + numberWhileLoop);
}
Console.WriteLine("The loop is finished.");

var someText = "hello";
while (someText.Length < 15)
{
    someText += 'a';
    Console.WriteLine(someText);
}
Console.WriteLine("The loop is finished.");

