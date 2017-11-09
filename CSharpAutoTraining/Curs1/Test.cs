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

            browser.ChangeWidnowWidth(1080);
            browser.ChangeWindowHeight(1920);

            browser.DisplayBrowserResolution();
        }
    }
}
