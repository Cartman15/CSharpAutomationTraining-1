using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Curs2Test
    {
        static void Main(string[] args)
        {
            Curs2Browser browser = new Curs2Browser();
            Curs2Firefox firefox = new Curs2Firefox();
            Curs2Chrome chrome = new Curs2Chrome();
            Curs2InternetExplorer ie = new Curs2InternetExplorer();

            chrome.DisplayWindowChrome();
            firefox.FirefoxConvert();
            ie.IEDisplay();

        }
    }
}
