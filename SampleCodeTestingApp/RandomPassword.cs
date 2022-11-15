using Bogus.Premium;
using Bogus;

namespace SampleCodeTestingApp;

public static class RandomPassword
{
    public static string Generate(int num)
    {
        return new Faker().Random.AlphaNumeric(num).ToUpper();
    }
}

public class Patient
{
    public string PatientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Password { get; set; }
    
    
}

// Generate Patient Details Using Bogus.Healthcare NuGet Package
public static class GeneratePatientDetails
{
    public static List<Patient> GeneratePatient()
    {
        var patient = new Faker<Patient>()
            .RuleFor(p => p.PatientId, f => f.Random.AlphaNumeric(25).ToUpper())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Age, f => f.Random.Number(5, 100))
            .RuleFor(p => p.Password, f => RandomPassword.Generate(15));
        return patient.GenerateBetween(100, 200);
    }
} 