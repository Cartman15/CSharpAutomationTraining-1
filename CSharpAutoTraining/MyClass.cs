using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining
{
    class MyClass
    {
        string Nume = "MyName";
        int Numar = 100;
        double numar2 = 110.22;
        char caracter = 'c';
        bool isWhatever = true;
        bool isWhatever2 = false;
        //bool? isWhatever2 = null;

        public void DisplayVariables()
        {
            Console.WriteLine(Nume);
            Console.WriteLine(Numar);
            Console.WriteLine(numar2);
            Console.WriteLine(caracter);
            Console.WriteLine(isWhatever);

            Console.WriteLine("Convert");
            Console.WriteLine(Convert.ToInt16(Nume));
            Console.WriteLine(Convert.ToInt16(isWhatever));
            Console.WriteLine(Convert.ToInt16(isWhatever2));

            Console.WriteLine("Operator");
            Console.WriteLine(Convert.ToInt16(Numar));
            Console.WriteLine(Convert.ToInt16(Numar++));
            Console.WriteLine(Convert.ToInt16(Numar));

            Numar = 100;
            Console.WriteLine(Convert.ToInt16(Numar));
            Console.WriteLine(Convert.ToInt16(++Numar));
            Console.WriteLine(Convert.ToInt16(Numar));

            Numar += 100;
            //Numar = Numar + 100; -asta inseamna linia de sus
            Console.WriteLine(Convert.ToInt16(Numar));
        }

    }
}
