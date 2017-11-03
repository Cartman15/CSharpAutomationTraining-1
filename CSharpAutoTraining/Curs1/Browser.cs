using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
   public class Browser
    {
        public int WindowWidth = 1024;
        public int WindowHeight = 768;
        public void ChangeWindowWidth(int increment)
        {
            WindowWidth = WindowWidth + increment;
            Console.WriteLine("WindowWidth is: {0}", WindowWidth);
        }
        public void ChangeWindowHeight(int increment)
        {
            WindowHeight = WindowHeight + increment;
            Console.WriteLine("WindowHeight is: {0}", WindowHeight);
        }

        public void DisplayBrowserResolution()
        {
            Console.WriteLine("Browser resolution is: {0}", WindowWidth + "x" + WindowHeight);
        }
    }
}
