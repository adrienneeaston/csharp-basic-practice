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