// See https://aka.ms/new-console-template for more information

/*  
string myString = "Hello, World!";
int myInt = 123;
DateTime myDateTime = DateTime.Now;
bool myBool = false;
    
Console.WriteLine(myBool);
Console.ReadKey();

------------------------------------------

var myName = "Victor";
var myAge = $"{myName}21";

Console.WriteLine(myAge);

------------------------------------------
*/

using C_;
var age = int.Parse(Console.ReadLine());
var operate = Console.ReadLine();
var age2 = int.Parse(Console.ReadLine());

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Calculate(operate, age, age2));
Console.ReadLine();