using System;
using System.Text.RegularExpressions;

namespace PROGassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var startup = new BootManager();

            // ✅ Play sound BEFORE UI
            startup.PlayStartupSound();

            string banner = @"
             [ GUARDIAN PROTOCOL v1.0 ]

                   .----------.
                  /   ______   \
                 /   /|    |    \
                |    ||____|     |
                |    |  __       |
                |    | /  \      |
                 \   | \__/     /
                  \  |         /
                   \ |________/
                    '--------'
            ";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(banner);
            Console.ResetColor();

            string profileName = "";
            bool isIdentityVerified = false;

            while (!isIdentityVerified)
            {
                Console.Write("\n[AUTH REQUIRED]: Identify yourself: ");
                profileName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(profileName))
                {
                    Console.WriteLine(">> Access Denied: Identification field cannot be null.");
                }
                else if (profileName.Length < 3)
                {
                    Console.WriteLine(">> Access Denied: Input too short for security clearance.");
                }
                else if (!Regex.IsMatch(profileName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine(">> Access Denied: Non-alphabetic characters detected.");
                }
                else
                {
                    isIdentityVerified = true;
                }
            }

            Console.WriteLine("\n+---------------------------------------+");
            Console.WriteLine($"| SESSION STARTED FOR: {profileName.ToUpper().PadRight(16)} |");
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("| Security Level: Authorized            |");
            Console.WriteLine("| System Monitoring: ACTIVE             |");
            Console.WriteLine("+---------------------------------------+");

            Console.WriteLine($"\nGreetings, {profileName}. Please state your query.");
            Console.ReadLine();
        }
    }
}