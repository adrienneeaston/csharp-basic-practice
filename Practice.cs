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