using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Program that displays browser resolution:");
            Browser browser = new Browser();                      
            browser.ChangeWindowWidth(896);            
            browser.ChangeWindowHeight(312);
            browser.DisplayBrowserResolution();
            Console.ReadKey();
        }
    }
}
