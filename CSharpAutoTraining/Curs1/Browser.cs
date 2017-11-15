using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1.Curs1
{
    public class Browser
    {
        public int Height = 1300;
        public int WindowWidth = 1024;
        public void ChangeWindowWidth(int increment)
        {
            WindowWidth = WindowWidth + increment;
        }
        public void ChangeWindowHeight(int increment2)
        {
            Height = Height + increment2;



        }
        public void DisplayWH()
        {
            Console.WriteLine("Width is {0} and Height is {1}", WindowWidth, Height);
        }
    }



}