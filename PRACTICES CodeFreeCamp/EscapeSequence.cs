﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICES_CodeFreeCamp
{
    class EscapeSequence
    {
        public static void Run()
        {
            Console.WriteLine("Character escape sequences: ");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!");
            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");

            //Verbatim string literal
            Console.WriteLine("Verbatim string literal");
            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
            Console.WriteLine(@"    hello everyone 
        my name /is //Prashant     Kumar
what's your name");
            //unicode escape characters \u
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

        }
    }
}
