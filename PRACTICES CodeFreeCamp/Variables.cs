using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

//Setting and getting values from variables
namespace PRACTICES_CodeFreeCamp
{
    class Variables
    {
        public static void Run()
        {
            string firstName;
            firstName = "Prashant";//setting a variable
            Console.WriteLine(firstName);//retrieve/getting the variable
            firstName = "Bob";
            Console.WriteLine(firstName);

        }
    }
}
