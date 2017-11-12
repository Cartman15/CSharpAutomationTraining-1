using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
  public class Curs2Firefox
    {
        public int WindowWidth_int = 101;
        public string WindowWidth_string = "1.6";
        public double WindowWidth_double = 10.2;

        public void FirefoxConvert()
        {
            string WindowWidthInt_string = Convert.ToString(WindowWidth_int);
            double WindowWidthString_double = Convert.ToDouble(WindowWidth_string);
            int WindowWidthDouble_int = Convert.ToInt16(WindowWidth_double);

            Console.WriteLine("This is the string value of the WindowWidth_int variable " + WindowWidthInt_string);
            Console.WriteLine("This is the double value for the WindowWidth_string " + WindowWidthString_double);
            Console.WriteLine("This is the int value for the WindowWidth_double " + WindowWidthDouble_int);
        }
    }
}
