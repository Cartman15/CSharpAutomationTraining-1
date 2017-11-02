﻿using System;
using CSharpAutoTraining.Curs1;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            //Console.WriteLine("Hello world");
            //Console.ReadKey();

            Browser browser = new Browser();
            browser.ChangeWidnowWidth(896);
            browser.ChangeWidnowHeight(200);
            //concatenare string 1
            Console.WriteLine("Browser resolution is " + browser.DisplayWidth().ToString() + " x " + browser.DisplayHeight().ToString());
            //concatenare string 2
            Console.WriteLine(string.Format("Browser resolution is {0} x {1}", browser.DisplayWidth(), browser.DisplayHeight()));
            Console.ReadKey();
        }
    }
}