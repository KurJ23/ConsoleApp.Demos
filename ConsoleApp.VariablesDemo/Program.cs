// See https://aka.ms/new-console-template for more information

string name = "Kurt Jansen";

Console.WriteLine(name);
Console.WriteLine("I am " +  name);
Console.WriteLine($"They call me {name}");
Console.WriteLine("I was given the name {0}", name);

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("my age is: " + age);
Console.WriteLine("my retirementAge is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);