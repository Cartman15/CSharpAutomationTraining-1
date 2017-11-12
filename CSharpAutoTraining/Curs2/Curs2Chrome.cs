using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
   public class Curs2Chrome
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayWindowChrome()
        {
            int WindowWidth_int = 1930;

            if (WindowWidth_int > 1920)
            {
                Console.WriteLine(WindowWidth_int);
            } else
            {
                Console.WriteLine("Window width less than 1920");
            }
        }
    }
}
