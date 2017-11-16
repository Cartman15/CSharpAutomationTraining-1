using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class TestCurs2

    {
        static void Main(string[] args)
        {
            BrowserCurs2 browser = new BrowserCurs2();
            FirefoxCurs2 firefox = new FirefoxCurs2();
            ChromeCurs2 chrome = new ChromeCurs2();
            IECurs2 ie = new IECurs2();

            chrome.DisplayWindowChrome();
            firefox.ConvertFirefox();
            ie.DisplayIE();

        }
    }
}
