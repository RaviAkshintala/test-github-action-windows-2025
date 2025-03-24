using CommandLine;
using System;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                // Successfully parsed arguments
                Console.WriteLine($"Flavor: {options.Flavor}");
                Console.WriteLine($"Environment: {options.Environment}");
                Console.WriteLine($"Version: {options.Version}");

                // You can now use these values in your application logic
                // For example, run your setup logic here
            })
            .WithNotParsed(errors =>
            {
                // Handle any parsing errors (optional)
                Console.WriteLine("Error parsing arguments");
            });
    }
}
