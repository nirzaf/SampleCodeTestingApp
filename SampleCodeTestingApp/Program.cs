// See https://aka.ms/new-console-template for more information


using System.Globalization;

using SampleCodeTestingApp;

string? input  = Console.ReadLine();

if (!input.Any())
{
    Console.WriteLine("No input");
}
else
{
    var result = input.ToUpper();
    Console.WriteLine(result);
}

Console.WriteLine("Press any key to exit");

/*
DateTime dateTime = Converters.ConvertStringToDate(input);

Console.WriteLine(dateTime.ToString(CultureInfo.InvariantCulture));
*/

//compare the input to the string "Hello" and ignore case
// WriteLine(input!.Contains("Hello", OrdinalIgnoreCase) ? "Hello World!" : "Goodbye World!");
//
// ReadLine();