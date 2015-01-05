using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.ProvdeBug
{
    public class Program
    {
        public class A { }
        public class B : A { }
        public class C : B { }
        public class Mock
        {
            public B publicField;
            private B privateField;
            protected B protectedField;
            internal B internalField;
            protected internal B protectedInternalField;

            public static B publicStaticField;
            private static B privateStaticField;
            protected static B protectedStaticField;
            internal static B internalStaticField;
            protected internal static B protectedInternalStaticField;

            public static readonly int readonlyStaticInt;
            public readonly int readonlyInt;
        }
        public class MockDerived : Mock
        {

        }

        static void Main(string[] args)
        {
            new Program().test();
        }

        public void test()
        {
            Console.WriteLine(Mock.readonlyStaticInt);
            typeof(Mock).GetField("readonlyStaticInt", BindingFlags.Public | BindingFlags.Static).SetValue(null, 2);
            Console.WriteLine(Mock.readonlyStaticInt);

            Console.ReadKey();
        }
    }
}
