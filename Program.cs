﻿//////////////// PRINT LITERAL VALUES ////////////////

// Literal String ""
Console.WriteLine("Hello World!");

// Character literals ''
Console.WriteLine('b');

// Integer Literals
Console.WriteLine(123);

// Floating Point Literals - Float Type "float" ~6-9 digits precision
// indicated with "F" or "f" literal suffix
Console.WriteLine(0.25F);

// Floating Point Literals - Float Type "double" ~15-17 digits precision
// The compiler defaults to the double literal when not entering a literal suffix
Console.WriteLine(0.2625);

// Floating Point Literals - Float Type "decimal" ~28-29 digits precision
Console.WriteLine(12.39816m);

// Boolean Literals - In C#, they're officially referred to as "bool", but often developers use the term "Boolean".
Console.WriteLine(true);
Console.WriteLine(false);

//////////////// SET AND GET VALUES FROM VARIABLES ////////////////

// declaring a variable: data type + name
// variable names: no $ or # allowed, must begin with _ or alphanumeric char, case-sensitive, not be C# keyword
string firstName;

// variable examples:
char userOption = 'c';
int gameScore = 100;
decimal particlesPerMillion = 1.123m;
bool processedCustomer = true;

// self note: noticed the terminal giving basic linter style warnings on `dotnet run` like: variable assigned but value never used
firstName = "Manon";
Console.WriteLine(firstName, userOption, gameScore, particlesPerMillion, processedCustomer);

// assigning variable value is known as a "set" operation
// retrieving a value from a variable is also known as a "get" operation

// variables can be reused and reassigned:
firstName = "Bob";
Console.WriteLine(firstName);