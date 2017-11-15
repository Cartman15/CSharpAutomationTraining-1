using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Firefox
    {
        int WindowWidth_int = 1920;
        string WindowWidth_string = "1e-35";
        double WindowWith_double = 1920.20;

        public void ConvertVariables()
        {
            Console.WriteLine("Int: {0}", WindowWidth_int);
            Console.WriteLine("String: {0}", WindowWidth_string);
            Console.WriteLine("Double: {0}", WindowWith_double);

            Console.WriteLine("Firefox: Convert Variables");
            Console.WriteLine(Convert.ToString(WindowWidth_int));
            Console.WriteLine(Convert.ToDouble(WindowWidth_string));
            Console.WriteLine(Convert.ToInt16(WindowWith_double));
        }

    }
}

