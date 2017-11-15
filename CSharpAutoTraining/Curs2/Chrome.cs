using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Chrome
    {
        int WindowWidth_int = 1920;
        string WindowWidth_string = "1e-35";
        double WindowWith_double = 1920.20;

        public void DisplayWindowWidth()
        {
            Console.WriteLine("Chrome: Display Window Width");
            if (WindowWidth_int >= 1920)
            {
                Console.WriteLine("WindowWidth is: {0}", WindowWidth_int);
            }
            else
            {
                Console.WriteLine("WindowWidth is less than 1920");
            }
        }
    }
}
