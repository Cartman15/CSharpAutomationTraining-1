using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class TestCurs2
    {
        static void Main()
        {
            BrowserCurs2 browser = new BrowserCurs2();

            Firefox firefox = new Firefox();
            firefox.ConvertVariables();
            Console.WriteLine();
            Console.ReadKey();

            Chrome chrome = new Chrome();
            chrome.DisplayWindowWidth();
            Console.WriteLine();
            Console.ReadKey();

            InternetExplorer internetexplorer = new InternetExplorer();
            internetexplorer.DisplayFor3Times();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
