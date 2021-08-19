Console.WriteLine("Hello World!");

// COMMENTS
// This is a single line comment

/*
This is a multiple line comment.
It has more than one line
*/

/// <summary>
/// This is an XML documentation comment. 
/// </summary>

// VARIABLES
// Declare a bool, an int, a double, a char, and a string
bool enabled;
int value;
double distance;
char level;
string greeting;

// Initialize all variables with values
bool enabled = true;
int value = 3;
double distance = 5.75;
char level = 'B';
string greeting = "Hello!";

// Print the values to the console
Console.WriteLine(enabled);
Console.WriteLine(value);
Console.WriteLine(distance);
Console.WriteLine(level);
Console.WriteLine(greeting);

// MIN/MAX VALUES
// Declare an int and initialize it to the max value
int maxScore = Math.Max(500, 300);

// Increment the int by one
maxScore++;

// Observe what happens
Console.WriteLine(maxScore);

// Implicit types
// Declare a bool, an int, a double, a char, and a string all using “var”
var enabled = true;
var value = 3;
var distance = 5.75;
var level = 'B';
var greeting = "Hello!";

// Operators
// Assignment and Increment/decrement
// Declare integers x and y and initialize them to any values
int x = 30;
int y = 25;

// Declare z1 = x++;
int z1 = x++;

// Declare z2 = ++y;
int z2 = ++y;

// Print the values of x, y, z1, and z2
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z1);
Console.WriteLine(z2);

// Math
// Declare integers x, y, and z, and initialize them to any values
int x = 30;
int y = 25;
int z = 100;

// Declare integers a, b, and c, and initialize them to any combination of math operations using x, y, and z
int a = x + y;
int b = y * z;
int c = z / y;

// Write an expression that returns true if x is even, and false if x is odd. Store the result of the expression in a bool.
if (x % 2 == 0) 
{
  bool result1 = true;
} else 
{
  bool result1 = false;
}

// Write an expression that returns false if y is divisible by 3. Store the result of the expression in a bool
if (y % 3 == 0) 
{
  bool result2 = false;
} 

// Write an expression that rounds a double to 3 decimal places and store the result in a double.
double value = 3.5874;
double newValue = Math.Round(value, 3);

// Type conversions
// 1. Declare integers x, y, and z and initialize them to any values
int x = 30;
int y = 25;
int z = 100;

// 2. Declare doubles a, b, and c and initialize them to any values
double a = 2.30;
double b = 4.8;
double c = 12.9999;

// 3. Store the integers in the doubles
a = (double)x;
b = (double)y;
c = (double)z;

// 4. Store the doubles in the integers
x = (int)a;
y = (int)b;
z = (int)c;