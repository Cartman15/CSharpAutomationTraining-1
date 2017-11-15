using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1.Curs1
{
    class Test
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();


            browser.ChangeWindowWidth(10);
            browser.ChangeWindowHeight(0);


            browser.DisplayWH();
        }


    }
}
