using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app.UI
{
    internal class Utilites
    {
        internal static void PrintMsg(string msg , bool success = true)
        {
            if(success) { 
            Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Utilites.PressEnterToCont();
        }
        internal static string GetUserInput(string prompat)
        {
            Console.WriteLine($"Enter {prompat}");
            return Console.ReadLine();
        }
        internal static void PressEnterToCont()
        {
            Console.WriteLine("\n Please press enter to contiune............ \n");
            Console.ReadLine();
        }
    }
}
