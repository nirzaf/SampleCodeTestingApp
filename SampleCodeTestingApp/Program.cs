// See https://aka.ms/new-console-template for more information


using System.Globalization;

using SampleCodeTestingApp;

string? input  = "2020-08-06";

DateTime dateTime = Converters.ConvertStringToDate(input);

Console.WriteLine(dateTime.ToString(CultureInfo.InvariantCulture));

//compare the input to the string "Hello" and ignore case
// WriteLine(input!.Contains("Hello", OrdinalIgnoreCase) ? "Hello World!" : "Goodbye World!");
//
// ReadLine();