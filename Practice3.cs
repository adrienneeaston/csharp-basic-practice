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

// Strings
// Escapes and literals
// 1. Create a string with escape sequences in it and print it out
string myString = "You should say \"Hello!\"";
Console.WriteLine(myString);

// 2. Create a literal string and print it out
string sentence = @"\path.cs";
Console.WriteLine(sentence);

// Concatenation
// 1. Concatenate two strings together and print them out
string greeting = "My name is ";
string name = "Adrienne!";
Console.WriteLine(greeting + name);

// Length
// 1. Print a string along with its length
string answer = "Hello there!";
Console.WriteLine($"String: {answer}, Length: {answer.Length}");

// Indexing
// 1. Create a string with length > 3 with an odd number of characters.
string characters = "starlight";

// 2. Print the first, middle, and last character, concatenated together.
Console.WriteLine($"{characters[0]}{characters[characters.Length / 2]}{characters[characters.Length - 1]}");

// 3. Make sure your code still works when you change the string size to a different odd number.
string characters = "stars";

// Changing case
// 1. Print a string, the same string in all uppercase, and the same string in all lowercase
string sentence = "I probably have ADHD.";
Console.WriteLine(sentence.ToUpper());
Console.WriteLine(sentence.ToLower());

// Getting parts of strings
// 1. Create a string with length > 3.
string characters = "stars";

// 2. Print the string with both the first and last characters removed.
string foo = characters.Remove(0, 1);
string bar = foo.Remove(foo.Length - 1, 1);
Console.WriteLine(bar);

// 3. Make sure your code still works if you change the string size.
string characters = "starlight";

// 4. Repeat the above exercise using a different string method.
Console.WriteLine(characters.Substring(1, characters.Length - 2));

// Searching
// 1. Declare strings x and char y and initialize them to whatever you like.
string x = "tattoo";
char y = 't';

// 2. Write an expression that returns the index of the first occurrence of char y in string x
Console.WriteLine(x.IndexOf(y));

// 3. Write an expression that returns a bool that represents if y is anywhere in string x
Console.WriteLine(x.Contains(y));

// 4. Create a literal string that holds a fake path to a file (@”c:\foo\bar.txt”, for example). Write code to get just the file name (no path), without the extension. Write code to get just the drive letter, in uppercase.
string fakePath = @"c:\foo\bar.txt";
int target = fakePath.LastIndexOf(@"\") + 1;
Console.WriteLine(fakePath.Substring(target));

// Splitting
// 1. Declare string x and initialize it to whatever you like. Make sure the string has spaces in it.
string sentence = "This is a string.";

// 2. Split the string on space and observe the results
string[] result = sentence.Split(' ');
Console.WriteLine(result);
foreach (var value in result)
{
    Console.WriteLine($"Substring: {value}");
}

// Formatting
// 1. Create a const string x that contains formatting tokens
const string x = "Hello! My name is {0}. I live in {1} and I enjoy {2}.";
const string name = "Adrienne";
const string city = "Seattle";
const string activity = "acting";

// 2. Create another string y that uses string.Format to insert values into string x
string y = string.Format(x, name, city, activity);

// 3. Print string y
double d = 5.0245;

// 5. Print the double, but only include 2 decimals when printing
Console.WriteLine(Math.Round(d, 2));

// Printing and parsing
// 1. Create bool a, int b, double c, and char d, and initialize them to whatever you want (other than default values).
bool a = false;
int b = 7;
double c = 3.14;
char d = 'w';

// 2. Convert these types to strings w, x, y, and z.
string w = a.ToString();
string x = b.ToString();
string y = c.ToString();
string z = d.ToString();

// 3. Create bool e, int f, double g, and char h. Use the appropriate Parse() method to initialize these variables from the strings w, x, y, and z.
bool e = bool.Parse(w);
int f = int.Parse(x);
double g = double.Parse(y);
char h = char.Parse(z);

// Enums
// 1. Create an enum inside the HelloWorld namespace, but outside of the Program class
enum Ids
{
  Apples,
  Grapes = 20,
  Oranges = 30,
  Blueberries = 10
}

// 2. Call the enum whatever you like, populate it with whatever names and values you like
enum Ids
{
  Apples,
  Grapes = 20,
  Oranges = 30,
  Blueberries = 10
}

// 3. Declare a variable and assign it to one of the enum values.
var target = Ids.Blueberries;

// 4. Using the variable, print both the enum name AND the enum value
Console.WriteLine(target); // Blueberries
Console.WriteLine((int)target); // 10

// Structs
// 1. Create a struct inside the HelloWorld namespace, but outside of the Program class
public struct student
{
  public string school;
  public int grade;
  public string learningStyle;
}

// 2. Call the struct whatever you like and add some members to it
public struct Student
{
  public string school;
  public int grade;
  public string learningStyle;
}

// 3. Declare a variable x and instantiate the struct
var x = new Student();
x.school = "Roosevelt High School";
x.grade = 10;
x.learningStyle = "kinesthetic";

// 4. Declare a variable y and instantiate the struct
var y = new Student();
y.school = "Ballard High School";
y.grade = 9;
y.learningStyle = "visual";

// 5. Set every member in x to the values of every member in y
x.school = y.school;
x.grade = y.grade;
x.learningStyle = y.learningStyle;

// 6. Print the members of x
Console.WriteLine(x.school);
Console.WriteLine(x.grade);
Console.WriteLine(x.learningStyle);

// Console I/O
// 1. Create a program that prompts the user for their first name, then middle name, then last name, all on different lines.
Console.WriteLine("Please enter your first name.");
var firstName = Console.ReadLine();
Console.WriteLine("Please enter your middle name.");
var middleName = Console.ReadLine();
Console.WriteLine("Please enter your last name."); 
var lastName = Console.ReadLine();

// 2. Print the first, middle, and last name all on the same line
Console.Write($"{firstName} {middleName} {lastName}");

// 3. Print “Press any key to exit…” and wait for the user to press a key to exit.
Console.WriteLine("Press any key to exit.");
Console.ReadKey();


// COME BACK TO THESE

// Command-line arguments
// 1. Create an enum called Direction with the values: Up, Down, Left, and Right
enum Direction
{
  Up,
  Down,
  Left,
  Right
}

// 2. Create a program that expects three arguments – a Direction, a bool, and an int.
enum Direction
{
    Up,
    Down,
    Left,
    Right
}
static void Main(string[] args)
{
    Console.WriteLine(args[0]);
    Direction direction = (Direction)Enum.Parse(typeof(Direction), args[0]);
    Console.WriteLine(direction);

    Console.WriteLine(args[1]);
    bool decision = Convert.ToBoolean(args[1]);
    Console.WriteLine(decision);

    Console.WriteLine(args[2]);
    int num = Convert.ToInt32(args[2]);
    Console.WriteLine(num);

}

// a. If the program is called with no arguments OR called with one argument of “/?”, print a help message explaining what arguments are expected with an example of a valid command line.
class Program
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("The following arguments are expected: Direction, bool, int (ie Down, true, 30)");
        }

        // Does this work?
        foreach (var arg in args)
        {
            if (arg.ToString() == "/?")
            {
                Console.WriteLine("The following arguments are expected: Direction, bool, int (ie Down, true, 30)");
            }
        }

        Console.WriteLine(args[0]);
        Direction direction = (Direction)Enum.Parse(typeof(Direction), args[0]);
        Console.WriteLine(direction);

        Console.WriteLine(args[1]);
        bool decision = Convert.ToBoolean(args[1]);
        Console.WriteLine(decision);

        Console.WriteLine(args[2]);
        int num = Convert.ToInt32(args[2]);
        Console.WriteLine(num);
    }
}