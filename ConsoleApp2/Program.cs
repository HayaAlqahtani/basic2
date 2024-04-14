// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int currentHour = 12;
if (currentHour >= 11 && currentHour <= 14) 
{
    Console.WriteLine("Time for lunch");
}

Console.WriteLine();

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine();

int count = 5;
while (count > 0)
{
    Console.WriteLine(count);
    count--;
}

Console.WriteLine();

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Sunday" };
foreach (string dayOfWeek in daysOfWeek)
{
    Console.WriteLine(dayOfWeek);
}
Console.WriteLine();
int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum of the numbers :" + sum);