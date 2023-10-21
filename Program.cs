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


//////////////// STRING CONCATENATION ////////////////


string frName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + frName + "!");


//////////////// STRING INTERPOLATION ////////////////


string msg = $"{greeting} {frName}!";
Console.WriteLine(msg);

int version = 11;
string updateTxt = "Update to Windows";
Console.WriteLine($"{updateTxt} {version}!");


//////////////// COMBINE VERBATIM LITERALS AND STRING INTERPOLATION ////////////////


// verbatim literal (@) and string interpolation ($) combined
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


//////////////// CHALLENGE ////////////////


string projName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:\n\t" + $@"c:\Exercises\{projName}\data.txt");
Console.WriteLine($"{russianMessage}\n\t" + $@"c:\Exercises\{projName}\ru-Ru\data.txt");


///////////////////////////////////////////////////
//////////////// NUMBER OPERATIONS ////////////////
///////////////////////////////////////////////////


//////////////// ADD TWO NUMERIC VALUES ////////////////


Console.WriteLine(" ");
int firstNum = 12;
int secondNum = 7;
Console.WriteLine(firstNum + secondNum);


//////////////// MIX DATATYPES TO FORCE IMPLICIT TYPE CONVERSION ////////////////

// use previously declared firstName string variable
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// when adding more numbers, compiler will still treat everything as a string
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// add parenthesis to make intentions more clear:
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");


//////////////// BASIC MATH OPERATIONS ////////////////


int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine(" ");

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient); // results in 1, which we don't want

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

int first = 7;
int second = 5;
decimal quot = (decimal)first / (decimal)second; // casting int to decimal
Console.WriteLine(quot);


//////////////// MODULUS FOR THE REMAINDER ////////////////


Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");


//////////////// ORDER OF OPERATIONS ////////////////


int val1 = 3 + 4 * 5;
int val2 = (3 + 4) * 5;
Console.WriteLine(val1);
Console.WriteLine(val2);


//////////////// INCREMENT AND DECREMENT ////////////////


int val3 = 0;           // val3 is 0 
val3 = val3 + 5;        // val3 is now 5
val3 += 5;              // val3 is now 10

int val4 = 0;           // val4 is 0
val4 = val4 + 1;        //val4 is 1
val4++;                 //val4 is now 2

// compound assignment operators: += -= *= ++ --
// they compound some operation in addition to assigning the result to the variable.

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
Console.WriteLine("Third decrement: " + value); // is now 1

// Using the increment operator before and after the value (similar to JS)
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}"); // only adds 1 on the next line
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value)); // adds one in this line


//////////////// CHALLENGE ////////////////


int fahrenheit = 94;
// subtract 32, multiply by 5/9 from F to C

decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celsius} Celsius");