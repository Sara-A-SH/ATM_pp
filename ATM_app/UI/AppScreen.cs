using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app.UI
{
    internal static class AppScreen
    {
        internal static void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "ATM machine";
            Console.WriteLine("---------------Welcome to the ATM machine---------------");
            Console.WriteLine("Please insert your card number and passowrd");
            Utilites.PressEnterToCont();
        }

        
    }
}
