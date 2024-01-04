//See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float a = 3;
a += 7;
Console.WriteLine(a);

float b = 4;
b -= 2;
Console.WriteLine(b);

float c = 5;
c *= 3;
Console.WriteLine(c);

float d = 10;
d /= 2;
Console.WriteLine(d);

bool areNumbersNotEqual = a != b;
Console.WriteLine($"Numbers {a} and {b} are not equal: {areNumbersNotEqual}");
Console.WriteLine($"Numbers {b} and {b} are not equal: {b != b}");

Console.WriteLine(a < b);
Console.WriteLine(a > b);

float sum = a + b;
Console.WriteLine(sum);


Console.WriteLine(c - d);

Console.WriteLine(d * c);
Console.WriteLine(c / d);

var div = c / d;

Console.WriteLine("Please enter your age");
string input = Console.ReadLine();
int age = int.Parse(input);
Console.WriteLine($"In next year you'll be {++age}");

bool var1 = true;

Console.WriteLine(var1);
Console.WriteLine(!var1);

bool var2 = false;
bool andResult = var1 && var2;
Console.WriteLine($"{var1} and {var2} = {andResult}");

bool orResult = var1 || var2;
Console.WriteLine($"{var1} or {var2} = {orResult}");
