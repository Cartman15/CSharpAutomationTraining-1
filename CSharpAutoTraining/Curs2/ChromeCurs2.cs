using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    public class ChromeCurs2
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayWindowChrome()
        {
            int WindowWidth_int = 1960;
            
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine(WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Window Width less than 1920");

            }
                    
         }
    }
}
