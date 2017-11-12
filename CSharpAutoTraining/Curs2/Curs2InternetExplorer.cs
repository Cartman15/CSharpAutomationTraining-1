using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
   public class Curs2InternetExplorer
    {
        public int WindowWidth_int = 192;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void IEDisplay()
        {
            if (WindowWidth_int > 1920)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Window width if WindowWidth_int > 1920");
                }
            } else
            {
                Console.WriteLine("Window width if WindowWidth_int > 1920");
            }
        }
    }
}
