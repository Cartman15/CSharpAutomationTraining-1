using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class InternetExplorer
    {
        int WindowWidth_int = 1920;
        string WindowWidth_string = "1e-35";
        double WindowWith_double = 1920.20;
        int i = 0;

        public void DisplayFor3Times()
        {
            Console.WriteLine("Internet Explorer: Display for 3 times");
            if (WindowWidth_int >= 1920)
            {
                //Metoda 1 - for
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("WindowWidth: {0}", WindowWidth_int);
                }

                //Metoda 2 - while
                /*while (i < 3)
                {
                    Console.WriteLine("WindowWidth: {0}", WindowWidth_int);
                    i++;
                }*/
            }
            else
            {
                Console.WriteLine("WindowWidth is: {0}", WindowWidth_int);
            }
        }
        
    }
}
