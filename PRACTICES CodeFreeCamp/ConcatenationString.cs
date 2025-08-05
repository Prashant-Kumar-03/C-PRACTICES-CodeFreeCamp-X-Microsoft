using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICES_CodeFreeCamp
{
    class ConcatenationString
    {
        public static void Run()
        {
            // Concatenation is the process of joining two or more strings together.
            // In C#, you can concatenate strings using the + operator or the String.Concat method.
            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);



            firstName = "Bob";
            string greeting = "Hello";
            message = greeting + " " + firstName + "!";
            Console.WriteLine(message);

            // You can also use string interpolation, which is a more readable way to concatenate strings.
            Console.WriteLine("---Using Interpolation technique to concatenate strings---");
            message = $"{greeting} {firstName}!";
            Console.WriteLine(message);

            message = $"Hello {firstName}!";
            Console.WriteLine(message);

            int version = 11;
            string updateText = "Update to Windows";
            message = $"{updateText} {version}";
            Console.WriteLine(message);

            //Avoid intermediate variables
            version = 11;
            updateText = "Update to Windows";
            Console.WriteLine($"{updateText} {version}!");

            //Combine verbatim literals and string interpolation
            Console.WriteLine("---Using verbatim literals and string interpolation---");
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            //execrise
            string eng = "View English output";
            projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($@"{eng}:
    c:\Exercise\{projectName}\data.txt
    ");

            Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt
");



            //OR
            projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t{englishLocation}\n");

            russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");
        }
    }
}
