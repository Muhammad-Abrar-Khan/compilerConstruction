using System;
using System.Collections.Generic;

namespace MyLexer
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Enter a string:");
string input = Console.ReadLine() ?? string.Empty;

            
            List<string> tokens = Tokenize(input);
            
            Console.WriteLine("Tokens:");
            foreach (var token in tokens)
            {
                Console.WriteLine(token);
            }
        }
static List<string> Tokenize(string? input)
{
    if (string.IsNullOrEmpty(input))
    {
        return new List<string>();
    }
    // Splitting by space for simplicity. You can enhance this.
    return new List<string>(input.Split(' '));
}

    }
}
