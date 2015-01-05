using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.ProveBug
{
    public class Program
    {
        public static readonly int readonlyStaticInt;
        public static readonly String readonlyStaticString;
        public static readonly bool readonlyStaticBool;

        static void Main(string[] args)
        {
            Console.WriteLine("Initial value of readonlyStaticInt: " + Program.readonlyStaticInt);
            typeof(Program).GetField("readonlyStaticInt", BindingFlags.Public | BindingFlags.Static).SetValue(null, 2);
            Console.WriteLine("New value of readonlyStaticInt: " + Program.readonlyStaticInt);
            Console.WriteLine();
            Console.WriteLine("Initial value of readonlyStaticString: " + Program.readonlyStaticString);
            typeof(Program).GetField("readonlyStaticString", BindingFlags.Public | BindingFlags.Static).SetValue(null, 2.ToString());
            Console.WriteLine("New value of readonlyStaticString: " + Program.readonlyStaticString);
            Console.WriteLine();
            Console.WriteLine("Initial value of readonlyStaticBool: " + Program.readonlyStaticBool);
            typeof(Program).GetField("readonlyStaticBool", BindingFlags.Public | BindingFlags.Static).SetValue(null, true);
            Console.WriteLine("New value of readonlyStaticBool: " + Program.readonlyStaticBool);

            Console.ReadKey();
        }
    }
}
