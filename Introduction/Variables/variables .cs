// string firstName;
// firstName = "Bob";
// int year = 5;
// string lastName = "Smith";
// float height = 5.5f;
// Console.WriteLine("Hello"+firstName+""+Latname+"You are"+year+"years old and"+height+"feet tall");

/*
*Character sequence in C# is called a string. A string is a sequence of characters enclosed in double quotes.
\ is an escape character. It is used to escape the character that follows it. For example, \n is a newline character.
\t is a tab character. It is used to insert a tab in the output.
*Variables are used to store data. A variable is a name given to a memory location in a program. The value stored in a variable can be changed during program execution.
*/

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.WriteLine("\nOutput Directory:\t");

/*
*String interpolation is a way to construct strings that include variables. It is a way to embed expressions inside string literals, using curly braces {}.
*The $ symbol is used to indicate that the string is an interpolated string.
*The curly braces {} are used to embed expressions inside the string.
*The expression inside the curly braces can be a variable, a property, or a method call.
*Example
*/
// //example
// string naame="John";
// int age=30;
// float height=5.7f;
// Console.WriteLine($"Hello {name},you are {age} years old and {height} feet tall");


/*
*Compining string lietral ,escape sequence,verbatim string unicode escape sequence and string interpolation
*verbatim string is a string that ignores escape sequences. It is created by prefixing the string with the @ symbol.
*Unicode escape sequence is a sequence of characters that represents a Unicode character. It is created by prefixing the sequence with \u.

*/

// string projectName = "ACME";
// string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
// Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
// Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");   

/*
*Convertion fahrenheit in celcius 
*/
//code example

int fahrenheit = 94;
decimal celcius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {celcius}°C.");s