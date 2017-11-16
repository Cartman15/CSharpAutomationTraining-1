using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    public class IECurs2
    {
        public int WindowWidth_int = 1910;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayIE()
        {
            if (WindowWidth_int > 1920)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Window width is", WindowWidth_int);
                    
                }
            } 
            else
            {
                Console.WriteLine("Window Width is less than 1920");

            }
        }
    }
}
