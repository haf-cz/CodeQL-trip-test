var userInput = Console.ReadLine();
if (userInput is null)
{
    Console.WriteLine("null input");
    return -1;
}
Console.WriteLine($"User input:'{userInput}'");
foreach (var line in File.ReadLines(userInput))
{
    Console.WriteLine(line);    
}
Process.Start("cmd.exe", userInput);
return 0;