using System.Diagnostics.CodeAnalysis;
using System.Text;

Console.WriteLine("Hello, World!");
//Environment.GetCommandLineArgs();
int value = 100;
if (args.Length > 0)
{
    value = int.Parse(args[0]);
}

Console.WriteLine($"Value: {value}");

StringBuilder stringBuilder = new StringBuilder();
for (int i = 1; i <= value; i++)
{
    if(i%3 == 0)
    {
        stringBuilder.Append("Fizz");
    }
    if (i%5 == 0)
    {
        stringBuilder.Append("Buzz");
    }
    Console.WriteLine(stringBuilder.Length == 0 ? i : stringBuilder.ToString());
    stringBuilder.Clear();
    
}