using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        //variable
        public int WindowWidth = 1024;
        public int WindowHeight = 880;

        //metode
        public void ChangeWidnowWidth(int increment)
        {
            WindowWidth = WindowWidth + increment;
        }

        public void ChangeWidnowHeight(int increment)
        {
            WindowHeight = WindowHeight + increment;
        }

        public int DisplayWidth()
        {
            return WindowWidth;
        }

        public int DisplayHeight()
        {
            return WindowHeight;
        }
    }
}
