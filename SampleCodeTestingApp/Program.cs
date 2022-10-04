// See https://aka.ms/new-console-template for more information


using static System.Console;
using static System.StringComparison;

string? input  = ReadLine();


//compare the input to the string "Hello" and ignore case
WriteLine(input!.Contains("Hello", OrdinalIgnoreCase) ? "Hello World!" : "Goodbye World!");

ReadLine();