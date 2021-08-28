// Conditionals
// If/else
// 1. Create an int x and set it to 1
int x = 1;

// 2. Write an if/else if/else statement that will check if x is less than, equal to, or greater than 100 and print an appropriate message for each case
if (x > 100)
{
Console.WriteLine("This number is greater than 100.");
} 
else if (x < 100)
{
Console.WriteLine("This number is less than 100.");
}
else 
{
Console.WriteLine("This number is equal to 100.");
}

// 3. Change the value of x to cause each case to be triggered
int x = 101;
int x = 100;

// Switch
// 1. Create an enum type. Name it whatever you like and populate it with whatever values you like.
enum Ids
{
  Apples,
  Bananas,
  Oranges
}

// 2. Write a switch statement that checks each value of the enum and does something for each match. Include one case that falls through to the next case.
var fruit = Ids.Bananas;

case Ids.Apples:
    Console.WriteLine("Yum! Apples!");
    break;

case Ids.Bananas:
    Console.WriteLine("Yum! Bananas!");
    break;

case Ids.Oranges:
    Console.WriteLine("Yum! Oranges!");
    break;

default:
    Console.WriteLine("Too bad you aren't hungry.");
    break;

// Order of operations
// 1. Create a string s and initialize it to whatever you like.
string s = "123456";

// 2. Write code that does the following using conditional operators:
// a. If the string length is less than 5 and is odd OR
// b. If the string length is greater than or equal to 10 and is even
// c. Print a message
if ((s.Length >= 5 && s.Length % 2 == 0) || (s.Length < 5 && s.Length % 2 != 0))
{
    Console.WriteLine("You did the thing!");
}

// 3. Change the string length to make sure your code works properly
string s = "1234";

// Nested conditionals
// 1. Duplicate the logic above using nested conditionals
if (s.Length >= 5)
{
    if (s.Length % 2 == 0)
    {
        Console.WriteLine("You did the thing!");
    }
}
else if (s.Length < 5)
{
    if (s.Length % 2 != 0)
    {
        Console.WriteLine("You did the thing!");
    } 
}

// 2. Do not use any conditional operators when comparing values
if (s.Length >= 5)
{
    if (s.Length % 2 == 0)
    {
        Console.WriteLine("You did the thing!");
    }
}
else if (s.Length < 5)
{
    if (s.Length % 2 != 0)
    {
        Console.WriteLine("You did the thing!");
    } 
}

// Loops
// While
// 1. Create an infinite while loop and run your program to see what happens
int x = 0;

while (x < 4)
{
  Console.WriteLine($"The value of x is {x}.");
}

// 2. Create a string s and initialize it to “0123456789”
string s = "0123456789";

// 3. Use a while loop to print every odd digit in the string, all on the same line.
int i = 0;
while (i < s.Length)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }

    i++;
}

// Do While
// 1. Duplicate the above logic using a Do While loop
int i = 0;
do
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }

    i++;
}
while (i < s.Length);

// For
// 1. Duplicate the above logic using a for loop
for (int i = 0; i < s.Length; i++)
{
      if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

// Foreach
// 1. Duplicate the above logic using a foreach loop
foreach (char i in s)
{
    if ((int)i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

// COME BACK TO THIS

// Nested loops
// 1. Imagine you have a hat with 5 different numbers in it. You take out numbers, one at a time, without putting them back.
// 2. Write code that prints out every possible combination of numbers you can get, in all the different orders you can get them. Use any type of loops you want.
for (int i = 0; arr.Length; i++)
{
  // declare input hatArray with 5 digits
  // declare empty newArray with space for 120 elements
  // add element[0] from hatArry to newArray
  // outer loop - iterate through hatArray from element[1] while iterater < hatArray.Length
  // inner loop1 - modify (with string.Insert method) each elemment by putting the target digit at element[0] for all elements in new array, increment and do again while incrementer < element.Length               
  // inner loop2 - iterate through elements in newArray while element[index] != null
  // hatArray [a, b, c, d, e]
  // newArray []
  // [a]
  // [ba, ab]
  // cba, cab, bca, acb, bac, abc]
  // and so on
}

// Loop flow control
// 1. Declare a string s and initialize it to whatever you want.
// a. Make sure the first character in your string is repeated somewhere else in the string
string s = "sass";

// 2. Write a loop that searches through the string and looks for another occurrence of the first character found.
// 3. If the character found doesn’t match the first one, the loop should immediately go to the next letter
// 4. If the character found matches, print the index of the match, and immediately exit the loop.
for (int i = 1; i < s.Length; i++)
{
    if (s[0] == s[i])
    {
        Console.WriteLine(i);
        break;
    }
}

// Arrays
// Single dimensional arrays
// 1. Create an int array of size 10. Use a while loop to fill the array with the numbers 1 through 10.
int[] foo = new int[10];
int i = 0;
while (i < 10)
{
    foo[i] = i + 1;
    i++;
}

// 2. Use a for loop to print the contents of the array in reverse order.
for (int j = foo.Length - 1; j >= 0; j--)
{
    Console.WriteLine(foo[j]);
}

// 3. Write code that prints the sum of all numbers in the array
foreach (int val in foo)
{
    sum += val;
}

Console.WriteLine(sum);

// 4. Print the contents of the array without using a loop
Console.WriteLine(string.Join(", ", foo));

// Multi-dimensional arrays
// 1. Create a 2D int array of any size
var foo = new int[3, 3];
foo[0, 0] = 1;
foo[0, 1] = 2;
foo[0, 2] = 3;
foo[1, 0] = 4;
foo[1, 1] = 5;
foo[1, 2] = 6;
foo[2, 0] = 7;
foo[2, 1] = 8;
foo[2, 2] = 9;

Console.WriteLine(foo[2, 2]); // 9

// 2. Use any loop(s) to store the product of the two indices in each element
// a. For example, the element at [2,3] should be set to 6
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        foo[i, j] = i * j;
    }
}

Console.WriteLine(foo[2, 2]); // 4

// 3. Print the contents of the array using a foreach loop
foreach (int i in foo) 
{
    Console.WriteLine(i + ", "); // hits every spot row by row in the 2d array
}

// Functions
// Basic functions
// 1. Write a function that prints out whatever string you pass into it. Call the function to make sure it works.
static void Sentence(string msg)
{
    Console.WriteLine(msg);
}

Sentence("Hello World!");

// 2. Write a function that concatenates three strings and returns the result. Call the function to make sure it works.
static void Sentence(string msg1, string msg2, string msg3)
{
    Console.WriteLine(msg1 + msg2 + msg3);
}

Sentence("Ad", "rie", "nne");

// 3. Write a function that takes in an int array, an int index, and an int value. The function should update the array at the specified index with the specified value. If the index is out of range, the function should do nothing. Call the function to make sure it works.
static void changeVal(int[] list, int i, int val)
{
    if (i < 5)
    {
        list[i] = val;
    }
}

int[] arr = { 1, 2, 3, 4, 5 };
changeVal(arr, 3, 100);
Console.WriteLine(arr[3]);

// 4. Write a function that takes in a string and returns a new string that contains every other word (starting from the first) in the original. Call the function to make sure it works.
// a. For example, passing in “to be or not to be” should return “to or to”
static string changeStr(string str)
{
    string[] result = str.Split(" ");
    foreach (string s in result)
    {
        int index = Array.IndexOf(result, s);
        if (index % 2 == 1)
        {
            result[index] = " ";
        }
    }

    string realResult = string.Join("", result);
    return realResult;
}

string test = changeStr("This is a test here.");

// 5. Write a function that takes in a string, an optional int parameter called index, and an optional int parameter called length. The function should return a substring of the original string starting at the specified index, with the specified length. Call the function to make sure it works.
// a. If the index or length are out of range, the function should return an empty string.
// b. If the index is not specified, start at index 0
// c. If the length is not specified (or is 0), take the rest of the string
static string subStr(string str, int index = 0, int length = 0)
{
    if (index >= str.Length || length > str.Length - index)
    {
        return "";
    }

    if (index == 0)
    {
        index = 0;
    }

    if (length == 0)
    {
        length = str.Length - index;
    }

    string result = str.Substring(index, length);
    return result;
}

Console.WriteLine($"result: {subStr("Adrienne", 4, 3)}");

// Reference type equality
// 1. Write a function called AreArraysEqual that returns bool. The function should take in two int arrays and return whether they contain the same elements, in the same order. Call the function to make sure it works.
// a. The function should return immediately as soon detects a mismatch
static bool AreArraysEqual(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    { 
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }

    return true;
}

int[] arr1 = { 1, 2, 3, 4 };
int[] arr2 = { 1, 2, 3, 4 };
Console.WriteLine($"result: {AreArraysEqual(arr1, arr2)}");

// Output parameters
// 1. Write a function that returns void with two int input parameters. The function should have four output parameters that should return the sum, difference, product, and quotient of the two inputs. Call the function to make sure it works.
static void Main(string[] args)
{
    int sum;
    int diff;
    int prod;
    int quotient;
    Calculate(7, 3, out sum, out diff, out prod, out quotient);

    Console.WriteLine($"The sum is {sum}.");
    Console.WriteLine($"The difference is {diff}.");
    Console.WriteLine($"The product is {prod}.");
    Console.WriteLine($"The quotient is {quotient}.");
}

static void Calculate(int num1, int num2, out int sum, out int difference, out int product, out int quotient)
{
    sum = num1 + num2;
    difference = num1 - num2;
    product = num1 * num2;
    quotient = num1 / num2;
}

// Reference parameters
// 1. Write a function that takes in a string and a reference to an int. The function should return the character at the index specified by the int.
// a. If the int is negative, the first character should be returned and the int should be changed to 0.
// b. If the int is larger than the string length, the last character should be returned and the int should be changed to the last index in the string.
static void Main(string[] args)
{
    Console.WriteLine($"Result: {character("California", 4)}");
}

static char character(string word, int index)
{
    if (index < 0)
    {
        index = 0;
    } 
    else if (index >= word.Length)
    {
        index = word.Length - 1;
    }
    
    return word[index];
}
