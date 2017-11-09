using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    public class Browser
    {
        //variable
        public int WindowWidth = 0;
        public int WindowHeight = 0;

        //method
        public void ChangeWidnowWidth(int increment)
        {
            WindowWidth = WindowWidth + increment;
        }

        //method
        public void ChangeWindowHeight(int increment)
        {
            WindowHeight = WindowHeight + increment;
        }

        public void DisplayBrowserResolution()
        {
            Console.WriteLine(WindowWidth + " " + WindowHeight);
        }
    }
}
