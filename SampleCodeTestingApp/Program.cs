// See https://aka.ms/new-console-template for more information


using System.Globalization;

using SampleCodeTestingApp;

var listOfPatient = new List<Patient>();

listOfPatient = GeneratePatientDetails.GeneratePatient();

foreach (var patient in listOfPatient)
{
    Console.WriteLine("Patient Id:" + patient.PatientId);
    Console.WriteLine("Patient Name:" + patient.FirstName + " " + patient.LastName);
    Console.WriteLine("Patient Age:" + patient.Age);
    Console.WriteLine("Patient Password: " + patient.Password);
}

// for (int i = 0; i < 100; i++)
// {
//     listOfPasswords.Add(RandomPassword.Generate(11));
// }
//
// foreach (var password in listOfPasswords)
// {
//     Console.WriteLine(password);
// }


string? input  = Console.ReadLine();

if (!input!.Any())
{
    Console.WriteLine("No input");
}
else
{
    var result = input!.ToUpper();
    Console.WriteLine(result);
}

Console.WriteLine("Press any key to exit");

/*
DateTime dateTime = Converters.ConvertStringToDate(input);

Console.WriteLine(dateTime.ToString(CultureInfo.InvariantCulture));
*/

/*compare the input to the string "Hello" and ignore case
 WriteLine(input!.Contains("Hello", OrdinalIgnoreCase) ? "Hello World!" : "Goodbye World!");
 ReadLine();*/