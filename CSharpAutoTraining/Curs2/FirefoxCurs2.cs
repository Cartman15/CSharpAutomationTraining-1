using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    public class FirefoxCurs2
    {
        public int WindowWidth_int = 120;
        public string WindowWidth_string = "2";
        public double WindowWidth_double = 13;


        public void ConvertFirefox()
        {
            string WindowWidthInt_string = Convert.ToString(WindowWidth_int);
            double WindowWidthString_double = Convert.ToDouble(WindowWidth_string);
            int WindowWidthDouble_int = Convert.ToInt16(WindowWidth_double);

            Console.WriteLine("String valuea of WindowWidth_int is" + WindowWidthInt_string);
            Console.WriteLine("Double value of WindowWidth_string is" + WindowWidthString_double);
            Console.WriteLine("int valuea of WindowWidth_double is" + WindowWidthDouble_int);

        }

    }
}
