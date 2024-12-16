

using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please enter your first name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
