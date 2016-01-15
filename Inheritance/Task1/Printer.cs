using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine("Base class Value: {0}", value);
        }
    }

    class FirstDerived : Printer
    {
        private ConsoleColor color = ConsoleColor.Green;

        public override void Print(string value)
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine("FirstDerived class Value: {0}", value);
            Console.ResetColor();
        }
    }

    class SecondDerived : Printer
    {
        private ConsoleColor color = ConsoleColor.Yellow;

        public override void Print(string value)
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine("SecondDerived class Value: {0}", value);
            Console.ResetColor();
        }
    }
}
