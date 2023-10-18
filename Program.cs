//////////////// PRINT LITERAL VALUES ////////////////


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



//////////////// DECLARE IMPLICITLY TYPED LOCAL VARIABLES ////////////////


// Implicitly typed local variable use the `var` keyword followed by variable initialization
var message = "Hello World!";
Console.WriteLine(message);
// The compiler will now imply data type of 'string' because of the assigned value being string. 
// assigning another data type to `message` will be met with an error
// var variables need to be initialized straight away, just declaring it will be met with an error. 


//////////////// CHALLENGE: DISPLAY LITERAL AND VARIABLE VALUES ////////////////


string fName = "Bob";
int msgAmount =  3;
decimal temperature = 34.4m;

Console.WriteLine("Hello, " + fName + "! You have " + msgAmount + " messages in your inbox. The temperature is " + temperature + " celsius.");
// Console.Write("Hello, ");
// Console.Write(fName);
// Console.Write("! You have ");
// Console.Write(msgAmount);
// Console.Write(" messages in your inbox. The temperature is ");
// Console.Write(temperature);
// Console.Write(" celsius.");

// the above was the solution code, but these work similar to JS so I put them in one WriteLine


//////////////// CHARACTER ESCAPE SEQUENCES ////////////////


// \n sequence will add a new line
Console.WriteLine("Hello\nWorld!");
// \t sequence will add a tab
Console.WriteLine("Hello\tWorld!");
// \" escape for handling double quotes
Console.WriteLine("Hello \"World\"!");
// use \\ for single backslash escaping
Console.WriteLine("c:\\source\\repos");



//////////////// FORMAT OUTPUT USING CHARACTER ESCAPE SEQUENCES ////////////////


Console.WriteLine();
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");


//////////////// VERBATIM STRING LITERAL ////////////////


// A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
// To create a verbatim string, use the @ directive before the literal string
Console.Write(@"c:\invoices");
// another example
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");


//////////////// UNICODE ESCAPE CHARACTERS ////////////////


// Kon'nichiwa World
Console.WriteLine();
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");


// IMPORTANT the examples used here are UTF-16. Some characters require UTF-32 and therefore require a different escape sequence

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// full example:

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");