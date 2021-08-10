Console.WriteLine("Hello World!");

string aFriend = "Adrienne";
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Adrienne";
string secondFriend = "Chris";
Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");

//Length
string firstFriend = "Adrienne";
string secondFriend = "Chris";
Console.WriteLine($"My Friend {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"My Friend {secondFriend} has {secondFriend.Length} letters.");

//Trim() TrimStart() TrimEnd()
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Replace()
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// ToUpper() ToLower()
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Contains() StartsWith() EndsWith()
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
Console.WriteLine(d);
// 3
// integers divided will always produce integers

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
// much smaller min and max than double

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
// wraps back around to negative if over max

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);
// capture decimals

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");
// Much larger min and max than INT

double third = 1.0 / 3.0;
Console.WriteLine(third);
// .3333333 rather than 1/3, not exact

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");
// min and max in greater than INT but smaller than double

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
// More precision, calculates out more decimal places than the double

// calculating area of a circle, all values in System.Math are doubles, so doubles should be used here
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

// braches
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");

int a = 5;
int b = 8;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

// C# typically uses curly braces on it's if/else statements
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

// while loop and language around the work
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }
    }
}

// do while loop
int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);

// for loop
for(int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

// combining branches and loops
int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");