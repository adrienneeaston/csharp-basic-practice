// escapes
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
// verbatum string literal
Console.WriteLine(@"c:\invoices");

// verbatim string literal and unicode escape characters
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

//concatenation
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob"; 
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// string interpolation
string firstName = "Bob"; 
string message = $"Hello {firstName}!";
Console.WriteLine(message);

string firstName = "Bob"; 
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

string firstName = "Bob"; 
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");

// combining verbatum string literals with interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// project
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\exercise\{projectName}\data.txt
    ");
Console.WriteLine($@"{russianMessage}:
    c:\exercise\{projectName}\ru-RUdata.txt");

// View English output:
// 		c:\Exercise\ACME\data.txt

// Посмотреть русский вывод:
// 		c:\Exercise\ACME\ru-RU\data.txt

// simple addition and implicit data conversion
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // 77

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // 14

// decimals
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine(decimalQuotient);

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// incrementing and decrimenting
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// position of the increment operator
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
// First: 2
// Second: 2
// Third: 3
// Fourth: 4
// when val++ is in a console log or being assigned to a variable, it will be asking for the return 

// mini project, converting fahrenheit to celcius
int fahrenheit = 94;
decimal celcius = ((decimal)fahrenheit - (decimal)32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celcius} Celcius.");

// classes with stateless and stateful methods
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Overloaded methods
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");