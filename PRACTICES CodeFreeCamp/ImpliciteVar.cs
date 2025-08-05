using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare implicitly typed local variables
namespace PRACTICES_CodeFreeCamp
{
    class ImpliciteVar
    {
        public static void Run()
        {
            var message = "Hello Prashant!";//the message variable is typed to be a string and can never be changed
            //message = 10.703m;  this will throw an error
            /*
            In other words, the type is locked in at the time of declaration and
            therefore will never be able to hold values of a different data type.
            */
            //Variables using the var keyword must be initialized
            //var message;   ERROR
            Console.WriteLine("Prining implicit variable value : {0} ",message);
            var name = "Bob";
            var roll = 3;
            var marks = 34.4;
            Console.Write("Hello, {0}! You have {1} messages in your inbox. The temperature is {2} celsius.", name, roll, marks);
        }
    }
}
