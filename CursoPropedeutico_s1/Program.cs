using System;

namespace CursoPropedeutico_s1
{
    struct myStructure
    {
        int z;
        bool b;
    }

    enum myEnum
    {
        BLACK,
        BROWN,
        RED,
        ORANGE,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            interactiveInput();

            primitiveTypes();
            objectTypes();
            
            Console.ReadKey();
        }

        static void interactiveInput()
        {
            Console.WriteLine("Please, enter your name and Press Enter");
            var name = Console.ReadLine();
            Console.WriteLine(displayName(name));

        }

        static private string displayName(string name)
        {
            //return $"Hello {name}";
            return string.Format("Hello {0}", name);
        }

        static void primitiveTypes()
        {

            int i = (int) myEnum.BROWN;
            bool b = true;
            byte c = 128;
            decimal d = 1.0M;
            double e = 1.5;
            char f = 'j';
            string g = "gnu";
            Single h;
            Int16 j;
            Int32 k;
            Int64 l;
            SByte m;
            UInt16 n;
            UInt32 o;
            UInt64 p;
            Console.WriteLine("An int i = " + i);
            Console.WriteLine("A char c = " + f);
        }

        static void objectTypes()
        {
            
            DateTime today = DateTime.UtcNow;
            

        }

    }
}
