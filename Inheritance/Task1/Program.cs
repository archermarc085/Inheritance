using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printer = new Printer[3];
            printer[0] = new Printer();
            printer[1] = new FirstDerived();
            printer[2] = new SecondDerived();

            foreach (Printer p in printer)
            {
                p.Print("Values");
            }

            if (printer[1] is FirstDerived)
            {
                var derived = (FirstDerived)printer[1];
                derived.Print("Text");
            }
            SecondDerived secondDerived = printer[2] as SecondDerived;
            if (secondDerived is SecondDerived)
            {
                SecondDerived second = (SecondDerived)secondDerived;
                second.Print("Text");
            }
            Console.ReadLine();
        }
    }
}
