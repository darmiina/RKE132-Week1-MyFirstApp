// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasjutajal sisestada tema nime
// Rakendus tervitab kasjutajat nimepidi

using System.Net.Security;

Console.WriteLine("Enter your name:"); // Output
//string - sõne
string userName = Console.ReadLine(); // Input

Console.WriteLine("Hello" + ", " + userName + "!"); // Output

// String interpolation

Console.WriteLine($"Hello, {userName} !"); // Output

