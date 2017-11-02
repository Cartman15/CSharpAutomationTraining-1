using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();

            Console.WriteLine(string.Format("Browser resolution is {0} x {1}", browser.DisplayWidth(), browser.DisplayHeight()));

            browser.ChangeWidnowWidth(896);
            browser.ChangeWidnowHeight(200);

            //concatenare string 1
            Console.WriteLine("Browser resolution is " + browser.DisplayWidth().ToString() + " x " + browser.DisplayHeight().ToString());
            //concatenare string 2
            Console.WriteLine(string.Format("Browser resolution is {0} x {1}", browser.DisplayWidth(), browser.DisplayHeight()));

            Console.ReadKey();
        }
    }
}
